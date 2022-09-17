using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        float xValue = Input.GetAxisRaw("Horizontal");
        float zValue = Input.GetAxisRaw("Vertical");

        transform.Translate(xValue * moveSpeed * Time.deltaTime, 0, zValue * moveSpeed * Time.deltaTime);
    }
}
