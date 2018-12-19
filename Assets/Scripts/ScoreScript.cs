using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour {
   
    public Text TextoPontos;
    public static int pontos;
   

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	 void Update () {
        
        TextoPontos.text =  pontos.ToString();
    }


   

}
