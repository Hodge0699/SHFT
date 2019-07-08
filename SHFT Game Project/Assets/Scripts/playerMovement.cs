using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float PlayerSpeed = 10;
    public CharacterController controller;
    private Vector3 moveDirection;
     void Start()
    {
        controller = GetComponent<CharacterController>();
    }

     void Update()
    {   // lets the player move in any direction
        moveDirection = (transform.forward * Input.GetAxisRaw("Vertical")) + (transform.right * Input.GetAxisRaw("Horizontal"));
        //Keeps the player movement speed at the correct speed when moving at an angle
        moveDirection = moveDirection.normalized * PlayerSpeed;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
      
