using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float enemySpeed;
    float horizontal;
    float vertical;
    public Transform Player;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Vector3 moveDirection = (Player.position - transform.position).normalized;
        rb.velocity = moveDirection * Time.deltaTime * enemySpeed;
    }
}
