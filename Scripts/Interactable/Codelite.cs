using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codelite : Interactable
{
    public Code code;
    public float nrmin;
    void Awake()
    {
        nrmin = code.nrcod;
    }
    protected override void Interact()
    {
        if(code.nrcod != nrmin && code.nrcod != nrmin + 1)
        code.nrcod--;
    }
}
