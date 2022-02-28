using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
public AudioSource a2;
    public Game_Over goo;   
    public int scoreValue;
    public float enemyhealth = 15f; 
    public Transform[] locations;
    public int length ; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(goo.game_ended==true)
        a2.Stop();
    }
    void OnTriggerEnter (Collider other){
        if (other.CompareTag("Bullet")){
            Destroy(other.gameObject);
            enemyhealth = enemyhealth - 5f;
            if (enemyhealth<=0) {
                
              
                int randomindex = Random.Range(0,length-1);
                Debug.Log(randomindex);
                enemyhealth = 10f; 
                transform.position = locations[randomindex].position;
                ScoreManager.instance.AddPoint();
            }
        }
    }
}