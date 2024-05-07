using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moove_start_left : MonoBehaviour
{
    public float speed = 30;

    void Start()
    {
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }

}
