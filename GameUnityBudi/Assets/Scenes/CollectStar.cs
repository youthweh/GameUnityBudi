using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar: MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        if (other.name == "budi")
        {
            ScoringSystem.theScore += 50;
        }
        Destroy(gameObject);
    }
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    
    }
}
