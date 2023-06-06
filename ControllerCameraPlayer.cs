/*....................................................

    DEV CRIATOR:JOAO
    DEV EDITOR: JOAO
    DATA CRIAÇÃO: 20/03/2023
    DATA EDIÇÃO: 31/03/2023
    PROJETO: GAME
    DESCRICAO SCRIPT: Configuração para a camera seguir e rotacionar ao redos do player

.....................................................*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //-------------------------Camera  Variaveis------------------------//
    
    public Transform player; // Referencia a player no cenario

    [SerializeField]
    private float sensitivity = 100f; //Sensibilidade ro Mouse

    [SerializeField]
    private float distance = 10f; // Distancia da camera em relação ao player

    [SerializeField]
    private float height = 3f; // altura da camera em relação ao player

    [SerializeField]
    private float minAngle = -20f; // angulo minimo em que a camera pode rotacionar

    [SerializeField]
    private float maxAngle = 80f; // angulo maximo em qua a camera pode rotacionar

    private float currentAngleX = 0f; // angulo X da camera fixa em relação ao player
    private float currentAngleY = 0f; // angulo Y da camera fixa em relação ao player
    //......


    //-------------------LateUpdadte Game-----------------//
    void LateUpdate()
    {
    // Obtém a rotação do mouse em torno do eixo X e do eixo Y
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Atualiza a rotação da câmera em torno do eixo Y
        currentAngleY += mouseX;
        Quaternion rotationY = Quaternion.Euler(0f, currentAngleY, 0f);

        // Atualiza a rotação da câmera em torno do eixo X
        currentAngleX -= mouseY;
        currentAngleX = Mathf.Clamp(currentAngleX, minAngle, maxAngle);
        Quaternion rotationX = Quaternion.Euler(currentAngleX, 0f, 0f);

        // Calcula a posição da câmera em relação ao jogador
        Vector3 direction = rotationY * rotationX * Vector3.forward;
        Vector3 playerPosition = player.position + new Vector3(0f, height, 0f) - direction * distance ;

        // Atualiza a posição da câmera
        transform.position = playerPosition;

        // Aponta a câmera para o jogador
        transform.LookAt(player.position + new Vector3(0f, height, 0f));
    }

}
