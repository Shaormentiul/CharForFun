using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButoaneLift : MonoBehaviour
{
    public int complet;
    public GameObject buton2;
    public GameObject buton3;
    public GameObject buton4;
    public GameObject buton5;

    void Update()
    {
        if(complet == 2)
        buton2.SetActive(true);
        if(complet == 3)
        buton3.SetActive(true);
        if(complet == 4)
        buton4.SetActive(true);
        if(complet == 5)
        buton5.SetActive(true);
       
    }
    
}
