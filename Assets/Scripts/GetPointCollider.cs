using UnityEngine;

public class GetPointCollider : MonoBehaviour
{
    [SerializeField]
    private BallMover ballMover;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.position.x > 0)
        {
            ScoreManager.Instance.AddPointPlayer();
        }
        else
        {
            ScoreManager.Instance.AddPointComputer();
        }
        ballMover.GoBall();
    }
}
