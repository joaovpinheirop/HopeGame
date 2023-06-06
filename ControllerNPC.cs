using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCameras : MonoBehaviour
{

    public Camera cameraPlayer;
    public Camera cameraMaquina;

    public Camera cameraReferencia;
    // Start is called before the first frame update
    void Start()
    {
        cameraReferencia = cameraMaquina;
        cameraReferencia.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MudarCamera(Camera newCamera)
    {
        cameraReferencia.enabled  = false;

        newCamera.enabled = true;

        cameraReferencia = newCamera;
        
    }
}
