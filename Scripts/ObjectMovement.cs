using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            movement += new Vector3(0.5f, 0, 0.5f);
        else if (Input.GetKey(KeyCode.S))
            movement -= new Vector3(0.5f, 0, 0.5f);

        if (Input.GetKey(KeyCode.A))
            movement -= new Vector3(0.5f, 0, -0.5f);
        else if (Input.GetKey(KeyCode.D))
            movement += new Vector3(0.5f, 0, -0.5f);

        movement.Normalize();
        transform.position += movement * _speed * Time.deltaTime;
    }
}
