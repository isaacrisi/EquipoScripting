using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class AIActionHeal : AIAction
{
    [Tooltip("Cantidad de vida a curar cada vez que se activa")] 
    public float healAmount = 20f;
    [Tooltip("Tiempo mínimo entre curaciones")] 
    public float minHealCooldown = 3f;
    [Tooltip("Tiempo máximo entre curaciones")] 
    public float maxHealCooldown = 8f;
    private float _nextHealTime;
    private Health _health;

    public override void Initialization()
    {
        base.Initialization();
        _health = this.gameObject.GetComponent<Health>();
        SetNextHealTime();
    }

    public override void PerformAction()
    {
        if (_health == null) { return; }
        if (Time.time >= _nextHealTime)
        {
            _health.GetHealth(healAmount, this.gameObject);
            SetNextHealTime();
        }
    }

    private void SetNextHealTime()
    {
        _nextHealTime = Time.time + Random.Range(minHealCooldown, maxHealCooldown);
    }
}
