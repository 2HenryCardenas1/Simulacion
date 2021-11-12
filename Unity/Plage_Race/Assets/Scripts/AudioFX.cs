using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Hecho por : Henry Esteban Cardenas Aleman
// Linkedin : www.linkedin.com/in/henry-esteban-cardenas-aleman-95507b126
// github : 2HenryCardenas1
public class AudioFX : MonoBehaviour
{
  public AudioClip[] fxs;
  AudioSource audioS;

  void Start()
  {
      audioS = GetComponent<AudioSource>();
  }

  public void FXSonidoChoque()
  {
      audioS.clip = fxs[0];
      audioS.Play();
  }

   public void FXMusic()
  {
      audioS.clip = fxs[1];
      audioS.Play();
  }

  public void FXSonidoMasDiez()
  {
      audioS.clip = fxs[2];
      audioS.Play();
  }

  public void FXSonidoMenos10()
  {
      audioS.clip = fxs[3];
      audioS.Play();
  }
}































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































//Hecho por : Henry Esteban Cardenas Aleman
// Linkedin : www.linkedin.com/in/henry-esteban-cardenas-aleman-95507b126
// github : 2HenryCardenas1