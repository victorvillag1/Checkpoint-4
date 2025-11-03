using UnityEngine;

public class PowerUpTrigger : MonoBehaviour
{
    // --- REFERENCIAS A CONECTAR EN EL INSPECTOR ---
    [Header("Efectos del Player a activar")]
    // 1. El GameObject del círculo en el suelo (permanente)
    public GameObject efectoSueloCorrespondiente;
    // 2. El GameObject del efecto de partículas de recolección (destello de un disparo)
    public GameObject efectoRecoleccionCorrespondiente;

    private void OnTriggerEnter(Collider other)
    {
        // 1. Verifica si el objeto que entró tiene el Tag "Player".
        if (other.CompareTag("Player"))
        {
            // 2. Busca el script del personaje.
            PowerUpManager playerManager = other.GetComponent<PowerUpManager>();

            if (playerManager != null)
            {
                // 3. Llama a la función del Player, enviando ambas referencias.
                playerManager.ActivarEfecto(efectoSueloCorrespondiente, efectoRecoleccionCorrespondiente);

                // 4. Desaparece el Power-Up.
                gameObject.SetActive(false);
                Destroy(gameObject, 0.1f);
            }
            else
            {
                // Mensaje de error si olvidaste poner el PowerUpManager en el Player
                Debug.LogError("El script PowerUpManager no se encontró en el Player. ¡Asegúrate de que está ahí!");
            }
        }
    }
}