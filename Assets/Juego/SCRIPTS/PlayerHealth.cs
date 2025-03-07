using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    private bool isInvincible = false;

    // M�todo para activar o desactivar la invencibilidad
    public void SetInvincible(bool state)
    {
        isInvincible = state;
        Debug.Log("Invencibilidad activada: " + state);

        // Opcional: aqu� puedes agregar efectos visuales para indicar el estado de invencibilidad
    }

    // M�todo para recibir da�o
    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            health -= damage;
            Debug.Log("Da�o recibido. Salud restante: " + health);

            if (health <= 0)
            {
                Die();
            }
        }
        else
        {
            Debug.Log("Jugador invencible, no se recibe da�o.");
        }
    }

    // M�todo que se ejecuta cuando la salud llega a 0
    private void Die()
    {
        Debug.Log("Jugador ha muerto.");
        // Aqu� puedes agregar la l�gica para reiniciar el nivel o mostrar una pantalla de Game Over.
    }
}
