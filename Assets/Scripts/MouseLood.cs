using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLood : MonoBehaviour
{
    public float MouseSenstivity = 100f;
    public Transform player;
    float xRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState= CursorLockMode.Locked;
        //transform.localRotation = Quaternion.Euler(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*MouseSenstivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*MouseSenstivity*Time.deltaTime;
        xRotation -=mouseY;
        xRotation =  Mathf.Clamp(xRotation,-90,30); 
        transform.localRotation = Quaternion.Euler(xRotation,0,0);
        player.Rotate(Vector3.up*mouseX);
    }
}