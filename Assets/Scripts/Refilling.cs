using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Refilling : MonoBehaviour
{   
    public shooting shoot;
    public Transform[] loc;
    public int len;
    public float max_bullets;
     



    void OnTriggerEnter(Collider colinfo){
        
        if(colinfo.CompareTag("Crate")){
             shoot.bullets= shoot.max_bullets;
            shoot.maxammo = 200;
            shoot.currentammo = shoot.defaultammo;
            int index = Random.Range(0,len-1);
            colinfo.transform.position = loc[index].position;

            
        }
    }

    }
