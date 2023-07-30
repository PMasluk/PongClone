using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerMover : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private float speed;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        transform.position = new Vector2(startPosition.x, Mathf.Lerp(transform.position.y, ball.transform.position.y, speed));
    }
}
