using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABCD : Interactable
{
    public int i;
    public Quiz q;

    protected override void Interact()
    {
        q.Answer(i);
        
    }
}
