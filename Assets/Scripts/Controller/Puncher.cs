using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Puncher : MonoBehaviour
{
    public int staminaToLoose = 2;
    public int staminaToGet = 1;


    private InputMaster _input;
    [SerializeField]private Animator _anim;
    [SerializeField]private PlayerState playerState;

    [SerializeField]private AudioSource audio;

    private bool lPunch = false;
    private bool rPunch = false;
    private bool uPunch = false;
    private bool blocking = false;

    private void FixedUpdate() {
        if(lPunch){
            playerState.TakeStamina(staminaToLoose);
            playerState.isAttacking =false;
            _anim.SetBool("LeftPunch", false);
            lPunch = false;
        }
        if(rPunch){
            playerState.TakeStamina(staminaToLoose);
            _anim.SetBool("RightPunch", false);
            rPunch = false;
            playerState.isAttacking = false;
        }
        if(uPunch){
            playerState.TakeStamina(staminaToLoose);
            _anim.SetBool("UpPunch", false);
            uPunch = false;
            playerState.isAttacking = false;
        }
        if(blocking){
            _anim.SetBool("Block", false);
            blocking = false;
            playerState.isBlocking = false;
        }
    }

    // private void OnCollisionEnter2D(Collision2D other) {
    //     if(other.gameObject.tag == "Enemy"){
    //         if(playerState.isAttacking == true)
    //             Debug.Log("ENEMY!");
    //             audio.Play();
    //     }
    // }

    public void LeftPunch(InputAction.CallbackContext context){
        _anim.SetBool("LeftPunch", true);
        playerState.isAttacking = true;
        if(context.canceled){
            lPunch = true;
        }
       // Debug.Log("LeftPunched");
    }

    public void RightPunch(InputAction.CallbackContext context){
        playerState.isAttacking = true;
        _anim.SetBool("RightPunch", true);
        if(context.canceled){
            rPunch = true;
        }
       // Debug.Log("RightPunched");
    }

    public void UpPunch(InputAction.CallbackContext context){
        playerState.isAttacking = true;
        _anim.SetBool("UpPunch", true);
        if(context.canceled){
            uPunch = true;
        }
       // Debug.Log("UpPunched");
    }

    public void Block(InputAction.CallbackContext context){
        playerState.isBlocking = true;
        _anim.SetBool("Block", true);
        if(context.canceled){
            blocking = true;
        }
    }

}
