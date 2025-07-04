using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (rend != null)
                rend.enabled = !rend.enabled;
        }
    }
}
