using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "budi")
        {
            SceneManager.LoadScene("Finish");
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
