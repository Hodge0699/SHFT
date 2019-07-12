using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{  // Player movement  Varibles 
    public float PlayerSpeed = 10;
    public CharacterController controller;
    private Vector3 moveDirection;
    // player stats 
    public float Health = 200;
    public float Mana = 100;
    public float basicAttack = 50;
    public float SpecialAttack = 100;
    public float Defense = 50;
    public float luck;
    public float scaling;

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
      
