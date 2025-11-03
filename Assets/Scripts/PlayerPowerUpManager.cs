using UnityEngine;

public class PlayerPowerUpManager : MonoBehaviour
{
    [Header("Referencias de Efectos")]
    public GameObject efectoSueloAzul;
    public GameObject efectoSueloVerde;
    public GameObject efectoSueloAmarillo;

    [Header("Referencias de Shader")]
    public Renderer characterRenderer; // Arrastra aquí la malla/Renderer del personaje
    public string shaderPropertyName = "_BaseColor"; // ¡REEMPLAZA con el nombre que anotaste en el Paso 3!

    // Colores que asignaremos al Shader para cada Power-Up
    private Color colorAzul = Color.blue;
    private Color colorVerde = Color.green;
    private Color colorAmarillo = Color.yellow;

    // Optimización para el Shader
    private MaterialPropertyBlock propBlock;

    void Awake()
    {
        // Inicializar el MaterialPropertyBlock
        propBlock = new MaterialPropertyBlock();

        // Asegurarse de que los efectos de suelo estén apagados al inicio.
        DesactivarTodosLosEfectosDeSuelo();
    }
