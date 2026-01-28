using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Animator))]

public class Character : MonoBehaviour
{
    // Private variables
    [Header("Character Stats")]
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;

    private bool isDead = false;
    protected Animator anim;

    // Public properties

    public float MoveSpeed
    {
        // read only
        get { return isDead; }
    }

    protected int CurrentHealth
    {
        get { return currentHealth; }
        set { currentHealth = Mathf.Clamp(value, 0, maxHealth); }
    }

    protected virtual void Awake()
    {
        anim = GetComponent<Animator>();
        Debug.Log("Awake in Character.cs");
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        // Level of protection
        if (IsDead)
        {
            return;
        }
    }

    protected void Die()
    {
        isDead = true;
        Debug.Log($"{gameObject.name} has died.");
    }
}
