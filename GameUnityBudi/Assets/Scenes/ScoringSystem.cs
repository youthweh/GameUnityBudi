using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    void Update() 
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
        scoreText.GetComponent<Text>().text = "Skor: " + theScore;
    }
  
}
