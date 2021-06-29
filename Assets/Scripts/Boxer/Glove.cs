using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glove : MonoBehaviour
{

    [SerializeField]private int damage;
    [SerializeField]private AudioSource audio;
    private PlayerState playerState;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy"){
            playerState = other.gameObject.GetComponent<PlayerState>();

            if(playerState.isBlocking){
                playerState.TakeStamina(damage);
            }else playerState.TakeDamage(damage);
            
            audio.Play();
        }
    }
}
