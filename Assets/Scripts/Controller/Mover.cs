using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
 //   private InputMaster _input;
    [SerializeField]private Animator _anim;
    [SerializeField]private PlayerState playerState;

    private float moveBy;
    [SerializeField] private float _speed = 5f;

    private void FixedUpdate() {
        //Debug.Log(moveBy);
        if(!playerState.isBlocking){
            transform.position += new Vector3(moveBy * Time.deltaTime * _speed, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        moveBy = 0f;
    }

    public void Move(InputAction.CallbackContext context){
        moveBy = context.ReadValue<float>();
        if(moveBy <= 0.5f && moveBy >= -0.5f){
            moveBy = 0;
            _anim.SetBool("MoveForward", false);
            _anim.SetBool("MoveBack", false);
        } 

        if(moveBy > 0.5f) _anim.SetBool("MoveForward", true);
        else if(moveBy < -0.5f) _anim.SetBool("MoveBack", true);
       // Debug.Log(moveBy);
    }



}
