using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Color pink = new Color(1f, 0.478f, 0.478f);
    Color brown = new Color(0.819f, 0.266f, 0f);
    Color purple = new Color(0.678f, 0.074f, 0.682f);
    Color indigo = new Color(0.196f, 0.031f, 0.631f); 

   public void Red(){
       GetComponent<Renderer>().material.color = Color.red;
   }

   public void Blue(){
       GetComponent<Renderer>().material.color = Color.blue;
   }

   public void Black(){
       GetComponent<Renderer>().material.color = Color.black;
   }

   public void Yellow(){
       GetComponent<Renderer>().material.color = Color.yellow;
   }

   public void Brown(){
       GetComponent<Renderer>().material.color = brown;
   }

   public void Pink(){
       GetComponent<Renderer>().material.color = pink;
   }

   public void Green(){
       GetComponent<Renderer>().material.color = Color.green;
   }

   public void Purple(){
       GetComponent<Renderer>().material.color = purple;
   }

   public void Indigo(){
       GetComponent<Renderer>().material.color = indigo;
   }
}
