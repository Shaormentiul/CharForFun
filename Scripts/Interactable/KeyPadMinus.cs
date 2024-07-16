using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadMinus : Interactable
{

    public Images im;
    public Keypad key;
    protected override void Interact()
    {
        if( key.i != 0)
        im.ChangeImage(key.i - 1);
        key.i--;
        
    }
}
