using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    [HideInInspector]
    public Rigidbody2D rb;

    public Vector2 movement;
    public bool isFeared = false;

    public static PlayerController instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (!Mathf.Approximately(0, movement.x))
        {
            transform.rotation = movement.x > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
    }

    private void FixedUpdate()
    {
        if (!isFeared)
        {
            rb.MovePosition(rb.position + movement * movementSpeed * Time.deltaTime);
        }
        else
        {
            rb.MovePosition(rb.position + movement * movementSpeed * Time.deltaTime);
        }
        
    }
}
