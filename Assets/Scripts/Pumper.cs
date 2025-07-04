using UnityEngine;

public class Pumper : MonoBehaviour
{
    private Vector3 originalScale;
    public float scaleAmplitude = 0.3f;
    public float scaleFrequency = 2f;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        float scale = 1 + Mathf.Sin(Time.time * scaleFrequency) * scaleAmplitude;
        transform.localScale = originalScale * scale;
    }
}
