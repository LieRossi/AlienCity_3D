using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePorta : MonoBehaviour {

    public  int ValPedraAzul = 0;
    public  int ValPedraVerde = 0;
   
    private bool Porta = false;
    private  bool Aberto;
    public  static int ScoreA;
    public  static int ScoreV;


   private Animator anim;



   void Start() {
       anim = GetComponent<Animator>();
       anim.SetTrigger("Fechado");
        
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

  
    }


