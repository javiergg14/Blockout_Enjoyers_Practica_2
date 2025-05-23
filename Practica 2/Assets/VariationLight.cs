using UnityEngine;

public class SpotlightFlicker : MonoBehaviour
{
    public Light spotlight;
    public float minIntensity = 0f;
    public float maxIntensity = 1f;
    public float flickerSpeed = 0.1f;

    private float nextFlickerTime;

    void Start()
    {
        if (spotlight == null)
            spotlight = GetComponent<Light>();
    }

    void Update()
    {
        if (Time.time >= nextFlickerTime)
        {
            spotlight.intensity = Random.Range(minIntensity, maxIntensity);
            nextFlickerTime = Time.time + Random.Range(flickerSpeed * 0.5f, flickerSpeed * 1.5f);
        }
    }
}
