using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newenemy : MonoBehaviour
{
    public GameObject enemy;
    public float timegap ;
    public ScoreManager obj;
    
    public int n0 = 400;
    public int n ;
    // Start is called before the first frame update
    void Start()
    {
        n = n0;
        InvokeRepeating("SpawnObject",0f,timegap);

    }

    // Update is called once per frame
    void Update()
    {
        if (obj.score > n){
            if (timegap > 1){
            timegap = timegap -1 ;
            n = n + n0 ;
            }
        }

    }
     void SpawnObject(){
         GameObject newenemy =  Instantiate (enemy,transform.position,transform.rotation) as GameObject;

              }
}
