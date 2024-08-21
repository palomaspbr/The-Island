using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour
{

    public float movSpeed;
    Vector2 velocity;
    Rigidbody2D rb;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        velocity = Vector2.zero;
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.y = Input.GetAxisRaw("Vertical");

        UpdateAnimation();

        if (Input.GetKeyDown(KeyCode.Z)){
            animator.SetTrigger("Attack");
        }

    }

    void UpdateAnimation(){

        if(velocity != Vector2.zero){

            UpdateMovement();
            animator.SetBool("Speed", true);
            animator.SetFloat("Horizontal", velocity.x);
            animator.SetFloat("Vertical", velocity.y);

        }
        else {
            animator.SetBool("Speed", false);
        }
    }

    void UpdateMovement(){
        rb.MovePosition(rb.position + velocity * movSpeed * Time.fixedDeltaTime);
    }
}
