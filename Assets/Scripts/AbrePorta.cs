using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePorta : MonoBehaviour {

    public  int ValPedraAzul = 0;
    public  int ValPedraVerde = 0;
   //private PlayerController ValPedraAzul;
   //private PlayerController ValPedraVerde;
    private bool Porta = false;
    private  bool Aberto;
    public  static int ScoreA;
    public  static int ScoreV;


   private Animator anim;



   void Start() {
       anim = GetComponent<Animator>();
       anim.SetTrigger("Fechado");
        //ValPedraAzul  = GameObject.Find("valPedraAzul").GetComponent<PlayerController>();
        //ValPedraVerde = GameObject.Find("valPedraVerde").GetComponent<PlayerController>();
        //Porta = GameObject.Find("porta").GetComponent<PlayerController>();
        ScoreA = ValPedraAzul;
        ScoreV = ValPedraAzul;
   }

    void Update ()
    {
      if (ScoreA !=0 && ScoreV != 0)
        {
            anim.SetTrigger("Aberto");
            Aberto = true;
        }
    }

   /* public void Abrindo() {
        if (Porta =true)
        {
        anim.SetTrigger("Aberto");
        Aberto = true;
       }*/
    }


