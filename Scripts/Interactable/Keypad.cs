using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
    public int i;
    public Images im;
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Interact()
    {
        if(i != im.spriteList.Length)
        im.ChangeImage(i + 1);
        i++;
        
    }
}
