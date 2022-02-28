using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine;

public class shooting : MonoBehaviour
{
    public Game_Over goo1;
    public AudioSource ass2;
public Rigidbody projectile;
public float speed = 20f;
public float bullets = 50f;
public float max_bullets = 50f ;
    public int maxammo = 200;
    public int currentammo = 50;
    public float reloadspeed = 2f;
   // public Text AmmoText;
    public int defaultammo = 50;

    public bool needReload;
    // Start is called before the first frame update
    void Start()
    {
        currentammo = 50;  
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (maxammo > 0) {
                StartCoroutine(Reload());
            }
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (bullets > 0){
                
            Rigidbody instantiatedProjectile = Instantiate (projectile,transform.position,transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = (transform.forward)*speed ;
            if(!goo1.game_ended)
            ass2.Play();
            bullets = bullets - 1;
                currentammo = currentammo - 1;

            }
        }
      //  AmmoText.text = currentammo + "/" maxammo;
    }

    private IEnumerator Reload()
    {
        Debug.Log("Reload");
        yield return new WaitForSeconds(2);
        currentammo = defaultammo;
        bullets = 50;
        maxammo = maxammo - 50;
        needReload = false;
    }


   /* void OnTriggerEnter(Collider colinfo){
        if(colinfo.CompareTag("Crate")){
            Debug.Log("ammo refilled");
            bullets=max_bullets;
        }
    }*/
    void OnCollisionEnter(Collision colinfo){
           
        if(colinfo.collider.tag=="Crate"){
            Debug.Log("ammo refilled");
            bullets=max_bullets;
            maxammo = 200;
            currentammo = defaultammo;
        }
    }
}
