using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butonNivel : Interactable
{
    public int nivel;
    public Door dor;

    protected override void Interact()
    {
      if(SceneManager.GetActiveScene().buildIndex != nivel && dor.IsOpen == false)
        SceneManager.LoadScene(nivel);
    }
}
