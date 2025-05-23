using UnityEngine;

public class EmissivePulse : MonoBehaviour
{
    public Renderer targetRenderer;
    public Color baseColor = Color.red;
    public float intensity = 1f;
    public float pulseSpeed = 2f;

    private Material emissiveMaterial;

    void Start()
    {
        // Obtener el material instanciado (no afecta el original)
        emissiveMaterial = targetRenderer.material;

        // Asegura que el shader tenga Emission habilitado
        emissiveMaterial.EnableKeyword("_EMISSION");

        // Asegura que la emisión sea en tiempo real (no baked)
        emissiveMaterial.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;
    }

    void Update()
    {
        // Generar un valor pulsante con PingPong
        float emission = Mathf.PingPong(Time.time * pulseSpeed, 1.0f) * intensity;

        // Multiplica el color base por la intensidad (convertido a espacio gamma)
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

        // Aplicar el color resultante a la Emission
        emissiveMaterial.SetColor("_EmissionColor", finalColor);
    }
}
