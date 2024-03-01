using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float fuerza = 50;
    private Rigidbody rb;

    private AudioSource audioS;//Sonido del salto
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioS = GetComponent<AudioSource>();//Sonido del salto
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            rb.AddForce(new Vector3(0,fuerza,0));
            audioS.Play();//Sonido el salto
        }
    }
}
