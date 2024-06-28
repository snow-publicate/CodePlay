using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            movement.y = 1;  // 위로 이동 (Y축 양의 방향)
        if (Input.GetKey(KeyCode.S))
            movement.y = -1; // 아래로 이동 (Y축 음의 방향)
        if (Input.GetKey(KeyCode.A))
            movement.x = -1; // 왼쪽으로 이동 (X축 음의 방향)
        if (Input.GetKey(KeyCode.D))
            movement.x = 1;  // 오른쪽으로 이동 (X축 양의 방향)

        rb.AddForce(movement.normalized * speed);
    }
}