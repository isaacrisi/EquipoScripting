﻿using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.CorgiEngine
{
    [AddComponentMenu("Corgi Engine/Character/AI/Actions/AIActionSelfDestruct")]
    public class AIActionSelfDestruct : AIAction
    {
        public bool OnlyRunOnce = true;
        public float ExplosionRadius = 2f;
        public int DamageToPlayer = 20;
        public LayerMask PlayerLayer;

        protected Character _character;
        protected Health _health;
        protected bool _alreadyRan = false;

        public override void Initialization()
        {
            if (!ShouldInitialize) return;
            base.Initialization();
            _character = this.gameObject.GetComponentInParent<Character>();
            _health = _character.CharacterHealth;
        }

        public override void PerformAction()
        {
            if (OnlyRunOnce && _alreadyRan)
            {
                return;
            }

            // Aplicar daño en área
            Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, ExplosionRadius, PlayerLayer);
            foreach (Collider2D hit in hits)
            {
                Health playerHealth = hit.GetComponent<Health>();
                if (playerHealth != null)
                {
                    playerHealth.Damage(DamageToPlayer, gameObject, 0f, 0f, Vector2.zero);
                }
            }

            // Autodestrucción
            _health.Kill();
            _brain.BrainActive = false;
            _alreadyRan = true;
        }

        public override void OnEnterState()
        {
            base.OnEnterState();
            _alreadyRan = false;
        }

        // Solo para visualización en el editor
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, ExplosionRadius);
        }
    }
}
