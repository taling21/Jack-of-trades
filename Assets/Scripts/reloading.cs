using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reloading : MonoBehaviour
{
    public shooting sss;

    public int startammo = 50;
    public int starttotal = 200;
    public int ammo;
    public int max;


    public Text AmmoText;

    // Start is called before the first frame update
    void Start()
    {

        AmmoText.text = "Ammo: " + startammo.ToString() + "/" + starttotal.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ammo = sss.currentammo;
        max = sss.maxammo;
        AmmoText.text = "Ammo: " + ammo.ToString() + "/" + max.ToString();
    }
}