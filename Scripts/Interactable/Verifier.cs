using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verifier : Interactable
{
    public int codCorect;
    public int varCorect;
    public float verCodeNum;
    public float verVarNum;
    public Code code;
    public Code code1;
    public Code code2;
    public Variable var;
    public Variable var1;
    public Variable var2;
    public Variable var3;
    public Variable var4;

    public void Update()
    {
        verCodeNum = 0;
        verCodeNum = verCodeNum * 10 + code.nrcod;
        verCodeNum = verCodeNum * 10 + code1.nrcod;
        verCodeNum = verCodeNum * 10 + code2.nrcod;


        verVarNum = 0;
        verVarNum = verVarNum * 10 + var.nrvar;
        verVarNum = verVarNum * 10 + var1.nrvar;
        verVarNum = verVarNum * 10 + var2.nrvar;
        verVarNum = verVarNum * 10 + var3.nrvar;
        verVarNum = verVarNum * 10 + var4.nrvar;
    }

    public bool wrong;
    private Door door;
    [SerializeField] private GameObject doorGameObject;
    private void Awake()
    {
        door = doorGameObject.GetComponent<Door>();


    }
     protected override void Interact()
    {
        if(verCodeNum == codCorect && verVarNum == varCorect)
        {
            door.Open();
            door.IsLocked = false;
        }
        else {
            Debug.Log(verCodeNum);
            Debug.Log(verVarNum);
            }
       
        if(wrong)
        {
            Debug.Log("Gresit");
        }
    }
}
