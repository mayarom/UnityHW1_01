using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Tooltip("Axis of rotation (e.g. (0,0,1) for Z axis)")]
    public Vector3 rotationAxis = new Vector3(0, 0, 1);

    [Tooltip("Rotation speed in degrees per second")]
    public float rotationSpeed = 90f;

    void Update()
    {
        transform.Rotate(rotationAxis.normalized * rotationSpeed * Time.deltaTime);
    }
}
