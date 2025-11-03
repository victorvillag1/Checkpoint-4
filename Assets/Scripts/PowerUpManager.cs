using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    // --- REFERENCIAS DE EFECTOS DE SUELO (PERMANENTES) ---
    [Header("Efectos de Suelo")]
    public GameObject efectoSueloAzul;
    public GameObject efectoSueloVerde;
    public GameObject efectoSueloAmarillo;

    // --- FUNCIONES BASE ---

    void Start()
    {
        // Se asegura de que todos los efectos estén apagados al inicio.
        DesactivarTodosLosEfectos();
    }

    // FUNCIÓN PRINCIPAL: Recibe las referencias y las activa.
    public void ActivarEfecto(GameObject efectoSueloAEncender, GameObject efectoRecoleccionAEncender)
    {
        // 1. Apaga el efecto de suelo anterior.
        DesactivarTodosLosEfectos();

        // 2. Enciende el efecto de suelo que le pasamos.
        if (efectoSueloAEncender != null)
        {
            efectoSueloAEncender.SetActive(true);
        }

        // 3. Reproduce el efecto de Recolección (partículas de un solo disparo).
        if (efectoRecoleccionAEncender != null)
        {
            // Busca el componente ParticleSystem en el GameObject que nos pasaron
            ParticleSystem ps = efectoRecoleccionAEncender.GetComponent<ParticleSystem>();

            if (ps != null)
            {
                ps.Play(); // Reproduce el efecto
            }
            else
            {
                Debug.LogError("¡ERROR! El objeto de recolección no tiene un componente ParticleSystem.");
            }
        }
    }

    // FUNCIÓN AUXILIAR: Apaga todos los efectos de suelo.
    private void DesactivarTodosLosEfectos()
    {
        if (efectoSueloAzul != null) efectoSueloAzul.SetActive(false);
        if (efectoSueloVerde != null) efectoSueloVerde.SetActive(false);
        if (efectoSueloAmarillo != null) efectoSueloAmarillo.SetActive(false);
    }
}