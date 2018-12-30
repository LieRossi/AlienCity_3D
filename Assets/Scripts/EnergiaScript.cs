using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnergiaScript : MonoBehaviour {
    public  Image BarraEnergia;
    private float fillAmount;
    public static float EnergiaCheia = 100;
    public static float EnergiaAtual;




    // Use this for initialization
    void Start() {
        EnergiaAtual = EnergiaCheia;


    }

    // Update is called once per frame
    void Update()
    {
        SistemaVida();
        SistemaBarras();

    }

    void SistemaVida()
    {

        if (EnergiaAtual >= EnergiaCheia)
        {
            EnergiaAtual = EnergiaCheia;

        }
        else if (EnergiaAtual <= 0)
        {
            EnergiaAtual = 0;
        }

        Debug.Log(EnergiaScript.EnergiaAtual);
    }

    void SistemaBarras()
    {
        //BarraEnergia.fillAmount -= Time.deltaTime/100;
        BarraEnergia.fillAmount = EnergiaScript.EnergiaAtual/100 ;
    }

    
}
