using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
public Rigidbody projectile;
public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiatedProjectile = Instantiate (projectile,transform.position,transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = (transform.forward)*speed ;
        }
    }
}