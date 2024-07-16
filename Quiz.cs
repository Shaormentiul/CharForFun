using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public GameObject texte;
    public FileManager fileMan;
    public ButoaneLift but;
    public Sprite[] spriteList;
    public string[] stringList;
    public int[] answerList;
    public GameObject Screen;
    public int n;
    public int j;
    public int count;
    public Door dor;
    public bool cooldown;

    void Start()
    {
        j = 0;
        cooldown = true;
        Shuffle();
        fileMan.ReadFromFile(stringList[0]);

    }

   

    public void Shuffle()
    {
        int l = stringList.Length;
        while(l > 1)
        {
           
            l--;
            int k = Random.Range(0, l + 1);
             Debug.Log(k);
            string s = stringList[k];
            int m = answerList[k];
            stringList[k] = stringList[l];
            answerList[k] = answerList[l];
            answerList[l] = m;
            stringList[l] = s;
        }
    }
    

    public void Answer(int ras)
    {
        if(cooldown)
        {
            j++;
            if(j == stringList.Length)
                {
                    texte.SetActive(false);
                    this.gameObject.GetComponent<Image>().sprite = spriteList[0];
                    StartCoroutine(SchimbaFin());
                }
            else if(ras == answerList[n] && cooldown)
            {
                cooldown = false;
                StartCoroutine(Cooldown());
                
                texte.SetActive(false);
                this.gameObject.GetComponent<Image>().sprite = spriteList[0];
                    StartCoroutine(Schimba());
                    FindObjectOfType<AudioManager>().Play("Correct");

                    Debug.Log("right");
                

            }
                
                //
            else 
            {
                if(cooldown)
                {
                    j++;
                    cooldown = false;
                    StartCoroutine(Cooldown());
                    if(j == stringList.Length)
                    {
                        texte.SetActive(false);
                        this.gameObject.GetComponent<Image>().sprite = spriteList[1];
                        StartCoroutine(SchimbaFin());
                    }
                    else
                    {
                        count++;
                        if(count != 3)
                        {
                            texte.SetActive(false);
                            this.gameObject.GetComponent<Image>().sprite = spriteList[1];
                            StartCoroutine(Schimba());
                            FindObjectOfType<AudioManager>().Play("Wrong");

                        }
                        else
                        {
                            texte.SetActive(false);
                            this.gameObject.GetComponent<Image>().sprite = spriteList[2];
                            StartCoroutine(SchimbaGr());
                            FindObjectOfType<AudioManager>().Play("Wrong");

                            
                        }
                    }
                }
                
            }
        }
          
            
            //

    }
    IEnumerator Cooldown()
    {
        n++;
        yield return new WaitForSeconds(3f);
        cooldown = true;
    }
    IEnumerator Schimba()
    {
        
        Debug.Log("Lol");
        yield return new WaitForSeconds(3f);
        ChangeImage(j);
        
    }
    IEnumerator SchimbaGr()
    {
        
        Debug.Log("Lol");
        yield return new WaitForSeconds(3f);
        Greseli();
        
    }
    IEnumerator SchimbaFin()
    {
        but.complet++;
        dor.IsLocked = false;
        Debug.Log("Lol");
        yield return new WaitForSeconds(3f);
        this.gameObject.GetComponent<Image>().sprite = spriteList[3];
        
    }
    public void ChangeImage(int i)
    {
        texte.SetActive(true);
        this.gameObject.GetComponent<Image>().sprite = spriteList[4];
        fileMan.ReadFromFile(stringList[i]);
    }
    
    public void Greseli()
    {
        count = 0;
        n = 0;
        j = 0;
        ChangeImage(j);
        
    }
}
