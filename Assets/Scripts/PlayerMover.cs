using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Update()
    {
        transform.position += new Vector3(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);
    }
}
