using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoTiempo : MonoBehaviour
{
    public GameObject cronometroGO;
	public Cronometro cronometroScript;

	public GameObject audioFXGO;
	public AudioFX audioFXScript;

	void Start()
	{
		cronometroGO = GameObject.FindObjectOfType<Cronometro>().gameObject;
		cronometroScript = cronometroGO.GetComponent<Cronometro>();

		audioFXGO = GameObject.FindObjectOfType<AudioFX>().gameObject;
		audioFXScript = audioFXGO.GetComponent<AudioFX>();
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.GetComponent<Coche>()!= null)
		{
			audioFXScript.FXSonidoMasDiez();
			cronometroScript.tiempo = cronometroScript.tiempo + 10;
			Destroy(this.gameObject);
		}
			
	}
}
