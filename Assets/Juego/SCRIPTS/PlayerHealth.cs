using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    private bool isInvincible = false;

    // Método para activar o desactivar la invencibilidad
    public void SetInvincible(bool state)
    {
        isInvincible = state;
        Debug.Log("Invencibilidad activada: " + state);

        // Opcional: aquí puedes agregar efectos visuales para indicar el estado de invencibilidad
    }

    // Método para recibir daño
    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            health -= damage;
            Debug.Log("Daño recibido. Salud restante: " + health);

            if (health <= 0)
            {
                Die();
            }
        }
        else
        {
            Debug.Log("Jugador invencible, no se recibe daño.");
        }
    }

    // Método que se ejecuta cuando la salud llega a 0
    private void Die()
    {
        Debug.Log("Jugador ha muerto.");
        // Aquí puedes agregar la lógica para reiniciar el nivel o mostrar una pantalla de Game Over.
    }
}
