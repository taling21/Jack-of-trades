using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController control;
    public float speed=10f;
    public int  maxHealth =100;
    public int currentHealth;
    //public HealthBar  healthBar;
    void Start()
    {
        currentHealth=maxHealth;
        //healthBar.SetMaxHealth(maxHealth); 
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right*x+ transform.forward*y;
        control.Move(move*speed*Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
        currentHealth-=damage;
        //healthBar.SetHealth(currentHealth);
    }
}