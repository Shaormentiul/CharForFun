using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Images : MonoBehaviour
{
    public GameObject Screen;
    public Sprite[] spriteList;
   
   
    
    public void ChangeImage(int i)
    {
        Screen.GetComponent<Image>().sprite = spriteList[i];
    }

    // Update is called once per frame
   
}
