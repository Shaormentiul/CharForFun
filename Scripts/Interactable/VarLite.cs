using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarLite : Interactable
{
    public Variable var;
   
    protected override void Interact()
    {
        if(var.nrvar != 1 && var.nrvar != 0)
        var.nrvar--;
    }
}
