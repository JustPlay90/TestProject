using UnityEngine;
using UnityEngine.SceneManagement;

public class Healh : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    private bool isAlive;

    public bool IsAlive
    {
        get { return isAlive; }
    }

    public float CurrentHealth
    {
        get { return currentHealth; }
    } 
       
    private void Awake()
    {
        currentHealth = maxHealth;
        isAlive = true;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        CheckIsAlive();
    }

    private void CheckIsAlive()
    {
        if (currentHealth > 0)
        {
            isAlive = true;
        }
        else
        {
            isAlive = false;
        }
    }   
}
