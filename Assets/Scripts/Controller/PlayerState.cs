using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerState : MonoBehaviour {

    [Header("Character preferences")]
    public int maxHealth = 100;
    public int currentHealth;

    public int maxStamina = 200;
    public int currentStamina;

    public int maxCritical = 100;
    public int currentCritical;

    [Header("UI elemets")]
    public Bar healthBar;
    public Bar staminaBar;
    public Bar criticalBar;

    [Header("Other elements")]
    [SerializeField]private Animator animator;

    [HideInInspector] public bool isBlocking = false;
    [HideInInspector] public bool isAttacking = false;
    [HideInInspector] public bool canAttack = true;

    private void Start() {
        currentHealth = maxHealth;
        healthBar.setMax(maxHealth);

        currentStamina = maxStamina;
        staminaBar.setMax(maxStamina);

        currentCritical = 0;
        criticalBar.setMax(maxCritical);
        criticalBar.setValue(currentCritical);
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        healthBar.setValue(currentHealth);
    
        if(currentHealth <= 0){
            currentHealth = 0;
            animator.SetBool("KOED", true);
        }
    
    }

    public void TakeStamina(int stamina){
        currentStamina -= stamina;
        currentCritical += stamina;
        if(currentStamina <= 0){
            currentStamina = 0;
            canAttack = false;
        }
        criticalBar.setValue(currentCritical);
        staminaBar.setValue(currentStamina);
    }

    

}
