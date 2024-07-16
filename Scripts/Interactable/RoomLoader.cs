using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLoader : MonoBehaviour
{
    public GameObject Cap1;
    public GameObject Cap2;
    public GameObject Cap3;
    public GameObject Cap4;

    public void Load(int i)
    {
        if(i == 1)
        {
            Cap1.SetActive(true);
            Cap2.SetActive(false);
            Cap3.SetActive(false);
            Cap4.SetActive(false);
        }
        if(i == 2)
        {
            Cap1.SetActive(false);
            Cap2.SetActive(true);
            Cap3.SetActive(false);
            Cap4.SetActive(false);
        }
        if(i == 3)
        {
            Cap1.SetActive(false);
            Cap2.SetActive(false);
            Cap3.SetActive(true);
            Cap4.SetActive(false);
        }
        if(i == 4)
        {
            Cap1.SetActive(false);
            Cap2.SetActive(false);
            Cap3.SetActive(false);
            Cap4.SetActive(true);
        }
        
    }
}
