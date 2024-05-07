using System.Collections;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float force;
    float z;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.AddForce(Vector2.left * force * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.AddForce(Vector2.right * force * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.AddForce(Vector2.up * force * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.AddForce(Vector2.down * force * Time.fixedDeltaTime);
        }
    }
    /*

    transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 65f, 0.0f), Time.deltaTime* 2f);
    transform.position += new Vector3(0.14f, 0f, 0.1f * Input.GetAxis("Horizontal"));
    */

}