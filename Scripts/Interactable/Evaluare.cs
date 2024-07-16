using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Evaluare : MonoBehaviour
{
    public TextMeshPro scorus;
    public GameObject bravo;
    public GameObject youSuck;
    public GameObject dipbun;
    public GameObject diprau;

    public int scor;

    void Update()
    {
        if(scor > 28)
        {
             bravo.SetActive(true);
             youSuck.SetActive(false);
             dipbun.SetActive(true);
             diprau.SetActive(false);
        }
           
        
       
    }

}
