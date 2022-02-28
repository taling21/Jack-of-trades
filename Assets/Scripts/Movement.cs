using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public AudioSource ais;
    bool isWalk=false;
    bool isPlay=false;
    public CanvasGroup cgg;
    public CharacterController control;
    public float speed=4f;
    public int  maxHealth =3000;
    public int currentHealth;
    public Game_Over go;
    public HealthBar  healthBar;
    public ScoreT ss;
    //public Animator anim;
  //  public bool isattacking = false;
    void Start()
    {
        currentHealth=maxHealth;
        healthBar.SetMaxHealth(maxHealth); 
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if(x!=0 || y!=0)
        isWalk=true;
        else
        isWalk=false;
        if(isWalk==true)
        {
            if(isPlay==false)
            ais.Play();
            isPlay=true;
        }
        else
        {
            ais.Stop();
            isPlay=false;
        }
        Vector3 move = transform.right*x+ transform.forward*y;
        control.Move(move*speed*Time.deltaTime);
        if(currentHealth<=10 && currentHealth>=0)
        {
           cgg.alpha=0;
           ss.Try();
           go.EndGame();

        }
       
    }
    public void TakeDamage(int damage)
    {
        currentHealth-=damage;
        healthBar.SetHealth(currentHealth);
      //  isattacking = true;
    }
}