using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    public Button jumpButton;
    private BoxCollider2D collider;
    private Rigidbody2D body;
    private Animator animator;
    private bool canJump = false;
    private float jumpForce = 12f;
    
    void Start()
    {
        //jumpButton = GameObject.find("JumpButton").GetComponent<Button>();
        collider = GetComponent<BoxCollider2D>();
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.Play("Running");

        jumpButton.onClick.AddListener(() => makeJump());
    }

    void makeJump() {
        if (canJump) {
            canJump = false;
            float forwardForce = 1.0f;
            if(transform.position.x<0){
                forwardForce = 1.0f;
            }else{
                forwardForce = 0.0f;
            }
            body.velocity = new Vector2(forwardForce,jumpForce);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(body.velocity.y) == 0) {
            canJump = true;
        }
    }
}
