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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
