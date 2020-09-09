using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public PlayerContoller playerContoller;
    public Animator playerAnimator;
    public bool is_move = false;

    // Start is called before the first frame update
    void Start()
    {
        playerContoller = GetComponent<PlayerContoller>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //transform.Translate(moveInput * Time.deltaTime * speed);
        Vector2 moveVelocity = moveInput.normalized * speed;

        playerContoller.Move(moveVelocity);

        playerAnimator.SetFloat("xPos", moveInput.x);
        playerAnimator.SetFloat("yPos", moveInput.y);

    }
}
