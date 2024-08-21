using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float horizontal;
    float vertical;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
    }
}
