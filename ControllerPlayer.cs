/*....................................................

    DEV CRIATOR:JOAO
    DEV EDITOR: JOAO
    DATA CRIAÇÃO: 20/03/2023
    DATA EDIÇÃO: 16/04/2023
    PROJETO: GAME
    DESCRICAO SCRIPT: Configuração para a movimentação do player
.....................................................*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

 //----------------------------Variaveis Player----------------------------//
    public float speed = 1f; //velocidade movimentação
    public float sensibility = 100f; //sensibilidade da rotação
    public float jumpForce = 500f;
    private Rigidbody rigidBody;
    private bool isPaused = false; // Variável para verificar se o jogo está pausado
    public bool movestatus = true;
    
    //--------------------------------------Start Game-------------------------------------// 
    void Start ()
    {
        rigidBody = GetComponent<Rigidbody>(); // buscar componente de rigbody
    }   
    //......
    //--------------------------------------Update Game-------------------------------------//
    void Update() // Metodo de atualização de quadros do jogo
    {
        MovimentationPlayer();//buscar metodo de movimentação do player
    }
    //......

    //-------------------------------------- Moving Player-------------------------------------//
    void MovimentationPlayer()//Metodo de movimentação do player
    {
    
        float moveHorizontal = Input.GetAxis ("Horizontal");//botões de movimentação horizontal
        float moveVertical = Input.GetAxis ("Vertical");//botões de movimentação vertical
        float mouseX = Input.GetAxis("Mouse X"); // eixo X do mouse

        // Calcular a direção de movimento
        Vector3 direction = new Vector3(moveHorizontal, 0f, moveVertical) * speed; // mudar diração de acordo com o valor horizontal e vertical com um determinada velocidade
        transform.Translate(direction * Time.deltaTime);//transformar sua posição na direção movimentada de acordo com o time do jogo
        
        //Calcular a rotação
        transform.Rotate( new Vector3(0 , (mouseX * sensibility) * Time.deltaTime,0));//Rotação de acordo com o eixo do X do mouse multiplicada com a sensiblidade e Time do jogo

         }
    //.....
   



 

}
