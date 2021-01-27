using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimScript : MonoBehaviour
{

    Animator animator;

    Rigidbody2D myRb;
    
    void Awake() {
        animator = GetComponent<Animator>();    
        animator.SetBool("Move",true);
        myRb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "obstacle"){
            animator.SetBool("Move",false);
        }
    }

     void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "obstacle"){
            animator.SetBool("Move",true);
        }
    }
}   
