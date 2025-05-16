using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    /*
    // Duración de la invencibilidad en segundos
    public float invincibilityDuration = 20f;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica que el objeto colisionado tenga el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Busca el componente PlayerHealth en el objeto del jugador
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                // Inicia la corrutina para aplicar el power‑up
                StartCoroutine(ApplyInvincibility(playerHealth));
            }
        }
    }

    IEnumerator ApplyInvincibility(PlayerHealth playerHealth)
    {
        // Activa la invencibilidad en el jugador
        playerHealth.SetInvincible(true);

        // Oculta el objeto Power‑Up y desactiva sus colisiones para evitar recolecciones dobles
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        // Espera la duración establecida
        yield return new WaitForSeconds(invincibilityDuration);

        // Desactiva la invencibilidad
        playerHealth.SetInvincible(false);

        // Destruye el objeto del power‑up
        Destroy(gameObject);
    }
    /*
    if (powerUp.tipo == TipoPowerUp.Especial)
    {
        GestorLogros.instancia.DesbloquearLogro("samuel Potenciado");
    }
    */
}
