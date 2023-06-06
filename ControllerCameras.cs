/*....................................................

    DEV CRIATOR:JOÃO
    DEV EDITOR: JOÃO
    DATA CRIAÇÃO: 12/05/2023
    DATA EDIÇÃO: 25/05/2023
    PROJETO: GAME
    DESCRICAO SCRIPT: Configuração das cameras

.....................................................*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCameras : MonoBehaviour
{

    public Camera cameraPlayer; // referencia da camera do player
    public Camera cameraMaquina;//referencia da camera da maquina

    public Camera cameraReferencia;//camera que esta como referencia no momento
    // Start is called before the first frame update
    void Start()
    {
        cameraReferencia = cameraMaquina;
        cameraReferencia.enabled = false;
    }

    /

    public void MudarCamera(Camera newCamera)
    {
        cameraReferencia.enabled  = false;

        newCamera.enabled = true;

        cameraReferencia = newCamera;
        
    }
}
