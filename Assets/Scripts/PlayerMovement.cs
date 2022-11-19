using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 movement;
    public Rigidbody rigidbody;
    public int speed;
    public Animator playerAnimator;
    public Transform playerCamera;
    public Vector2 mouseMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        Vector3 moveVector = transform.TransformDirection(movement) * speed;
        rigidbody.velocity = new Vector3(moveVector.x, rigidbody.velocity.y, moveVector.z);
        if (movement.x != 0 || movement.z != 0)
        {
            playerAnimator.SetBool("IsWalking", true);
        }
        else
        {
            playerAnimator.SetBool("IsWalking", false);
        }

        mouseMovement = new Vector2(Input.GetAxis("Mouse X"), 0);
        transform.Rotate(0, mouseMovement.x, 0);
        playerCamera.transform.localRotation = Quaternion.Euler(25,0,0);
    }
}
