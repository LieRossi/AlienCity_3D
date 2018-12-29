using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnergiaScript : MonoBehaviour {
    public Texture BarraEnergia;
    public static int VidaCheia = 100;
    public static int EnergiaPlayer;

	// Use this for initialization
	void Start () {
        EnergiaPlayer = VidaCheia;
		
	}
	
	// Update is called once per frame
	void Update () {
        if(EnergiaPlayer >= VidaCheia)
        {
            EnergiaPlayer = VidaCheia;
        }
        else if (EnergiaPlayer <=0)
        {
            EnergiaPlayer = 0;
        }

            //VidaCheia *Time.deltaTime;
            Debug.Log(EnergiaPlayer);
        

    }

   
}
