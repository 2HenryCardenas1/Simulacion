using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
