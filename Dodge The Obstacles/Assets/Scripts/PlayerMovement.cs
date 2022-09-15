using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float xValue = 0f;
    //[SerializeField] private float yValue;
    //[SerializeField] private float zValue = 0f;

    [SerializeField] private float moveSpeed;

    private void Start()
    {
        //transform.Translate(1, 0, 0);
    }

    private void Update()
    {
        float xValue = Input.GetAxisRaw("Horizontal");
        float zValue = Input.GetAxisRaw("Vertical");

        transform.Translate(xValue * moveSpeed * Time.deltaTime, 0, zValue * moveSpeed * Time.deltaTime);
    }
}
