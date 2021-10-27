using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbarTeclas : MonoBehaviour
{
    //1. Uso del mouse 
    void Update(){
        if (Input.GetMouseButtonDown(0))
    {
        Debug.Log("Boton izquierdo se ha presionado.Sola lo aplica una vez");
    }

    if(Input.GetMouseButton(0))
    {
        Debug.Log("Se esta presionando el boton izquierdo");
    }
    if(Input.GetMouseButtonUp(0))
    {
        Debug.Log("Se ha dejado de presionar el boton izquierdo");
    }

    //Uso del teclado


    if(Input.GetKeyDown(KeyCode.Space))
    {
        Debug.Log("Se ha oprimido el espacio");
    }

    //3.Usando las teclas de flechas izquierda o derecha

    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    if(horizontal < 0 || horizontal > 0)
    {
        Debug.Log("Horizontal axis is :" + horizontal);
    }

    if(vertical < 0 || vertical > 0)
    {
        Debug.Log("Vertical axis is :" + vertical);
    }
    }    
}
