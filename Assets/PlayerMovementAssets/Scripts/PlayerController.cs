using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    public float Speed = 10f;
    public float SprintMod = 2f;
    public float JumpForce = 10f;
    bool Sprint = false;

    public float groundDistance = 10.0f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    // Update is called once per frame
    void Update()
    {
        SprintCheck();
        if (Input.GetKeyDown(KeyCode.Space)) { Jump(); }
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = transform.right * horizontal + transform.forward * vertical;
        direction.Normalize();
        // direction *= (Sprint) ? Speed * SprintMod * Time.deltaTime * 100: Speed * Time.deltaTime * 100;
        direction *= (Sprint) ? Speed * SprintMod: Speed;
        direction.y = rb.velocity.y;

        rb.velocity = direction;
        //rb.MovePosition(direction);
        //Vector3 movementVector = new Vector3(horizontal, 0f, vertical) * Speed * SprintMod * Time.deltaTime;
        //if (movementVector.magnitude <= 0.1f) { rb.velocity = movementVector; }
    }

    void SprintCheck()
    {
        // Sprint Control
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Sprint = true;
        }
        else
        {
            Sprint = false;
        }
    }

    void Jump()
    {
        Debug.Log("Jump");
        if (JumpCheck() ) 
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
            Debug.Log("Check");
            //rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
    bool JumpCheck()
    {
        Ray raycast = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(raycast, out hit, groundDistance))
        {
            return hit.collider != null;
        }
        return false;
    }
}
