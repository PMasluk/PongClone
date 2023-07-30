using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D ballRigidbody;
    [SerializeField]
    private float speed;

    private void Start()
    {
        GoBall();
    }

    public void GoBall()
    {
        ballRigidbody.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        float random = Random.Range(0, 2);
        if (random < 1)
        {
            ballRigidbody.AddForce(new Vector2(15, -15) * speed);
        }
        else
        {
            ballRigidbody.AddForce(new Vector2(-15, -15) * speed);
        }
    }
    public Rigidbody2D GetBallRigidbody()
    {
        return ballRigidbody;
    }
}
