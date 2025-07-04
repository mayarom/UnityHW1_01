using UnityEngine;

public class Oscillator : MonoBehaviour
{
    private Vector3 startPosition;

    [Tooltip("Direction of oscillation (e.g. (1,0,0) for X axis)")]
    public Vector3 direction = Vector3.right;

    [Tooltip("Maximum distance from center")]
    public float amplitude = 2f;

    [Tooltip("Oscillation frequency")]
    public float frequency = 1f;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = startPosition + direction.normalized * offset;
    }
}
