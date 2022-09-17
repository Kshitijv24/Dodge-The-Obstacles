using UnityEngine;

public class Dropper : MonoBehaviour
{
    private Rigidbody rb;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();

        rb.useGravity = false;
        meshRenderer.enabled = false;
    }

    private void Update()
    {
        if(Time.time > 3)
        {
            rb.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}
