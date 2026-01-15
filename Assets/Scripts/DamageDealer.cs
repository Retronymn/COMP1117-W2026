using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DamageDealer : MonoBehaviour
{
    //public const string PLAYER_TAG = "Player";

    //Unity's recommendation
    [SerializeField] private PlayerController playerController;
    [SerializeField] private int damageToDeal = 15;

    /*private void Awake()
    {
        Not recommended, but still an option
        GameObject thePlayer = GameObject.FindGameObjectWithTag("Player");


        Better, but still not great
        PlayerController thePlayerControllerScript = GameObject.FindFirstObjectByType<PlayerController>();
        thePlayerControllerScript.TakeDamage(10);
        
    }*/
    /* public void Update()
     {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar pressed");
        }
     }*/


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar pressed");
        }
    }
    public void OnAttack(InputValue value)
    {
        if(value.isPressed)
        {
            if(playerController != null)
            {
                playerController.TakeDamage(damageToDeal);
                Debug.Log("Damage taken");
            }
            else
            {
                Debug.LogWarning("HEY BOZO!! DAMAGEDEALER.CS - PlayerController is null!");
            }
        }
    }
}
