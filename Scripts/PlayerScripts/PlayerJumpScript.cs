using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerJumpScript : MonoBehaviour
{

    [SerializeField] float forwardSpeed = 1, jumpSpeed = 12;

    Rigidbody2D myRb;

    [SerializeField]
    private bool canJump;
    
    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    AudioClip audioClip;
    // Start is called before the first frame update
    [SerializeField]
    Button jmpButton;
    
    void Awake()
    {
        myRb = GetComponent<Rigidbody2D>();
        jmpButton = GameObject.Find("Jump Button").GetComponent<Button>();
        jmpButton.onClick.AddListener(() => jump());
    }


    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(myRb.velocity.y) == 0){
            canJump = true;
        }
    }

    void jump(){
        if(canJump){
            canJump = false;
            audioSource.PlayOneShot(audioClip);
            if(transform.position.x < 0){
                forwardSpeed = 1f;
            }
            else {
                forwardSpeed = 0f;
            }
            myRb.velocity = new Vector2(forwardSpeed,jumpSpeed);
        }
    }



}
