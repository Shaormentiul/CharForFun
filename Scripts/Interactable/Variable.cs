using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class Variable : Interactable
{
    public float nrvar = 0;
    public string opt1;
    public string opt2;
    public string opt3;
    [SerializeField] private TextMeshPro lineGameObject;
    protected override void Interact()
    {
        if(nrvar != 3)
            nrvar++;
        
    }
    void Update()
        {
            if(nrvar == 1)
                lineGameObject.text = opt1;
                
            if(nrvar == 2)
                lineGameObject.text = opt2;
                
            if(nrvar == 3)
                lineGameObject.text = opt3;
        }
}
