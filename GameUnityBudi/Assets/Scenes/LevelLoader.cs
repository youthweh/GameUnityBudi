using UnityEngine;
using System.Collections;
 
public class LevelLoader : MonoBehaviour {
 
  
 
    void Start () {
     
    }
     
    public void LoadLevel (int a) {
 
        Application.LoadLevel (a);
    }
 
    public void Quit () {
 
        Application.Quit ();
    }
}