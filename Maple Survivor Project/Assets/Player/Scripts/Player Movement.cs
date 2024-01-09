using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Vector3 movementVector;

    [SerializeField] float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        rigid2D.velocity = moveSpeed * movementVector;

        if( rigid2D.velocity.x > 0)
        {
            transform.localScale = new Vector3( -1.0f, 1.0f, 1.0f);
        }
        else if (rigid2D.velocity.x < 0)
        {
            transform.localScale = new Vector3( 1.0f, 1.0f, 1.0f);
        }
    }
}
