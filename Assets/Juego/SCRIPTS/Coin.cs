using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidad de rotacion

    private void Update()
    {
        
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime); // Gira la moneda alrededor del eje Y
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // el jugador debe de tener el tag "Player"
        {
            Destroy(gameObject); // Destruye la moneda al tocarla
        }
    }
    if (totalMonedasRecogidas >= totalMonedasNivel)
{
    GestorLogros.instancia.DesbloquearLogro("Maestro Recolector");
}

}
