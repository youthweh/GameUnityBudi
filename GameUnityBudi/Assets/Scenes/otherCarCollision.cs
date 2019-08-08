using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherCarCollision : MonoBehaviour
{
    public AudioSource klaksonSound;
    void OnTriggerEnter(Collider other)
    {
        klaksonSound.Play();
   
    }
}
