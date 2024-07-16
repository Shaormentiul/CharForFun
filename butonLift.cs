using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonLift : Interactable
{
    public bool close;
    public Door dor1;
    public Door dor2;
    protected override void Interact()
    {
        if(!close)
        {
            dor1.Open();
            dor2.Open();
            
        }
        
        else 
        {
            dor1.Close();
            dor2.Close();
        }
    }
}
