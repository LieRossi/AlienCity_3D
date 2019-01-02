using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

    public float MoveSpeed;
    public float RotationSpeed;
    CharacterController cc;
    private Animator anim;
    protected Vector3 gravidade = Vector3.zero;
    protected Vector3 move = Vector3.zero;
    private bool jump = false;

    public int valPedraAzul = 0;
    public int valPedraVerde = 0;
    private bool Aberto;
    private bool porta;

   
    private int pontos;
    public Text TextoPontos;

    public Image BarraEnergia;


    void Start()
    {
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        anim.SetTrigger("Parado");


     
    }

    void Update()
    {
        Vector3 move = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * MoveSpeed;
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime, 0));

        if (!cc.isGrounded) {
            gravidade += Physics.gravity * Time.deltaTime;
        }
        else
        {
            gravidade = Vector3.zero;
            if (jump)
            {
                gravidade.y = 6f;
                jump = false;
            }
        }
        move += gravidade;
        cc.Move(move * Time.deltaTime);
        Anima();

       


    }

    void Anima()
    {
        if (!Input.anyKey)
        {
            anim.SetTrigger("Parado");
        }
        else
        {
            if (Input.GetKeyDown("space"))
            {
                anim.SetTrigger("Pula");
                jump = true;
            }
            else
            {
                anim.SetTrigger("Corre");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pedraAzul"))
        {
            valPedraAzul++;
            AbrePorta.ScoreA++;
            ScoreScript.pontos++;


            //Debug.Log(ScoreScript.pontos);
        }


        if (other.gameObject.CompareTag("pedraVerde"))
        {
            valPedraVerde++;
            AbrePorta.ScoreV++;
            ScoreScript.pontos++;


            //Debug.Log(ScoreScript.pontos);
        }

        
        if (other.gameObject.CompareTag("Boxparede"))
        {
            EnergiaScript.EnergiaCheia--;
            //Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Espinhos"))
        {
            EnergiaScript.EnergiaCheia--;
            //Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Lava"))
        {
            EnergiaScript.EnergiaCheia--;
            //Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Estalac"))
        {
            EnergiaScript.EnergiaCheia--;
            //Destroy(gameObject);
        }

        if (EnergiaScript.EnergiaCheia == 0)
        {
            Destroy(this.gameObject);
        }

    }

    
}