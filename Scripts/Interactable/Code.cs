using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class Code : Interactable
{
    [SerializeField] private GameObject sagVar;
    public bool sag = false;
    private bool pressed = false;
    public float nrcod = 0;
    public int nropt;
    public string opt1;
    public bool opt1act;
    public string opt2;
    public bool opt2act;
    public string opt3;
    public bool opt3act;
     [SerializeField] private TextMeshPro lineGameObject;

    
     
    protected override void Interact()
    {
        pressed = true;
        if(nrcod != nropt)
            nrcod++;
    }

    void Update()
    {
        if(pressed == true)
        {
                if(nrcod == 1)
            {
                lineGameObject.text = opt1;
                sag = true;
            }
                
            if(nrcod == 2)
            {
                lineGameObject.text = opt2;
                sag = true;
            }
                
            if(nrcod == 3)
            {
                lineGameObject.text = opt3;
                sag = true;
            }
        }
        else
        {
             lineGameObject.text = " ";
             sag = false;
        }
       
            
        sagVar.SetActive(sag);   
        
        
    }
}
