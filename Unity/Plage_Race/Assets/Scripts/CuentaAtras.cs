using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{
    public GameObject motorCarreteraGO;
	public MotorCarreteras motorCarreteraScript;
	public Sprite[] numeros;

	public GameObject contadorNumerosGO;
	public SpriteRenderer contadorNumerosComp;

	public GameObject controladorCocheGO;
	public GameObject cocheGO;

    // Start is called before the first frame update
    void Start()
    {
        InicioComponentes();
        
    }

    void InicioComponentes()
    {
        motorCarreteraGO = GameObject.Find("MotorCarretera");
		motorCarreteraScript = motorCarreteraGO.GetComponent<MotorCarreteras>();

		contadorNumerosGO = GameObject.Find("ContadorNumeros");
		contadorNumerosComp = contadorNumerosGO.GetComponent<SpriteRenderer>();

		cocheGO = GameObject.Find("Coche");
		controladorCocheGO = GameObject.Find("ControladorCoche");

		InicioCuentaAtras();

    }

    void InicioCuentaAtras()
    {
        StartCoroutine(Contando());
    }

    IEnumerator Contando()
	{
        
       //Ejecutamos el sonido del coche y espere 2seg
        controladorCocheGO.GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (2);
         //Cambia el numero del contador
		contadorNumerosComp.sprite = numeros[1];
		this.gameObject.GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(1);
        //Cambia el numero del contador
		contadorNumerosComp.sprite = numeros[2];
		this.gameObject.GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(1);
         //Llamamos la variable inicio juego y ponemos los audios 
		contadorNumerosComp.sprite = numeros[3];
		motorCarreteraScript.inicioJuego = true;
		contadorNumerosGO.GetComponent<AudioSource>().Play();
		cocheGO.GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(2);

		contadorNumerosGO.SetActive(false);
	}

    
}