using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fundidos : MonoBehaviour
{
    public Image fundido;
	public string[] escenas;

	void Start () 
	{
        //Permite hacer fundidos
		fundido.CrossFadeAlpha(0,2f,false);
	}

	public void FadeOut(int s)
	{
		fundido.CrossFadeAlpha(1,2f,false);
		StartCoroutine(CambioEscena(escenas[s]));
	}

	IEnumerator CambioEscena(string escena)
	{
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene(escena);
	}
}
