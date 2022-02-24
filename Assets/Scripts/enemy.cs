using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //public ScoreHub scoreHub;
    public int scoreValue;
    public float enemyhealth = 10f;
    public Transform[] locations;
    public int length ; 
    // Start is called before the first frame update
    void Start()
    {
        //scoreHub =transform.parent.GetComponent<ScoreHub>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider other){
        if (other.CompareTag("Bullet")){
            Destroy(other.gameObject);
            enemyhealth = enemyhealth - 5f;
            if (enemyhealth<=0) {
                //scoreHub.UpdateScore(scoreValue);
                int randomindex = Random.Range(0,length-1);
                Debug.Log(randomindex);
                transform.position = locations[randomindex].position;
            };
        }
    }
}