using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rb;
    public GameObject bala;
    public Transform firePoint;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, firePoint);
        }

        Move();
    }

    public void Move()
    {
        rb.velocity = transform.right * HorizontalInput() * moveSpeed;
    }

    public float HorizontalInput()
    {
        return Input.GetAxis("Horizontal");
    }
    
    
}
