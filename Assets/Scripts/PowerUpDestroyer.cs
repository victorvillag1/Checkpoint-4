using UnityEngine;

public class PowerUpDestroyer : MonoBehaviour
{
    // Esta función se llama automáticamente cuando otro collider (marcado como Trigger) entra.
    private void OnTriggerEnter(Collider other)
    {
        // 1. Verifica si el objeto que tocó el Power-Up tiene el Tag "Player".
        if (other.CompareTag("Player"))
        {
            // 2. Si es el jugador, desactiva el Power-Up inmediatamente.
            // Esto hace que el objeto desaparezca de la vista y deje de funcionar.
            gameObject.SetActive(false);

            // Opcional, pero recomendado: Destruye el objeto completamente después de 0.1 segundos.
            Destroy(gameObject, 0.1f);

            // ¡Aquí iría la lógica futura de efectos/sonido!
        }
    }
}
