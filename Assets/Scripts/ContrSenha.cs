using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContrSenha : MonoBehaviour {

    
    public int valPedraAzul = 0;
    public int valPedraVerde = 0;
    private GameObject porta;
    private bool aberto = false;

    private Animator anim;



    void Start() {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Fechado");
    }
	
	 void Update ()
     {
        AbrePorta();
     }

    void AbrePorta() {
        if (valPedraAzul >= 1 && valPedraVerde >= 1)
        {
            anim.SetTrigger("Aberto");
            aberto = true;
        }
    }
}
