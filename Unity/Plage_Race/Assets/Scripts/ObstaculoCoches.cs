using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Hecho por : Henry Esteban Cardenas Aleman
// Linkedin : www.linkedin.com/in/henry-esteban-cardenas-aleman-95507b126
// github : 2HenryCardenas1
public class ObstaculoCoches : MonoBehaviour
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
			audioFXScript.FXSonidoChoque();
			cronometroScript.tiempo = cronometroScript.tiempo - 20;
			Destroy(this.gameObject);
		}
			
	}
}































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































//Hecho por : Henry Esteban Cardenas Aleman
// Linkedin : www.linkedin.com/in/henry-esteban-cardenas-aleman-95507b126
// github : 2HenryCardenas1