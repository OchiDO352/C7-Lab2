using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changcolors : MonoBehaviour
{
  public void getRed(){
         GetComponent<Renderer>().material.color = Color.red; 
    }
    public void getGreen(){
        GetComponent<Renderer>().material.color = Color.green; 
    }
    public void getBlue(){
        GetComponent<Renderer>().material.color = Color.blue; 
    }
}
