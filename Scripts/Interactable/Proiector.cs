using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Proiector : Interactable
{
    public bool closed;
    public VideoPlayer vid;
    public GameObject proj;
   
    protected override void Interact()
    {
        if(!closed)
        {
            
            closed = true;
            proj.GetComponent<Animator>().Play("proiector");
            vid.enabled = false;
           
        }
        
        else 
        {   
            closed = false;
            proj.GetComponent<Animator>().Play("proiectorClose");
            StartCoroutine(Bideo());
        }
    }

    IEnumerator Bideo()
    {
        yield return new WaitForSeconds(1.0f);
         vid.enabled = true;
    }
    
}
