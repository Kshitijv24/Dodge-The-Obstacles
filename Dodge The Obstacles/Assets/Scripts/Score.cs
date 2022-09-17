using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("You bumped into a thing " + score + " times.");
        }
    }
}
