using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class FileManager : MonoBehaviour
{
    public TextMeshProUGUI codeBox;
    public TextMeshProUGUI promptBox;
    public TextMeshProUGUI ABox;
    public TextMeshProUGUI BBox;
    public TextMeshProUGUI CBox;
    public TextMeshProUGUI DBox;

    public string numeCapitol;
    string [] namesArray;
    public string [] fileArray;
    int i;
    string myFilePath;

    

    // Update is called once per frame
    public void ReadFromFile(string fileName)
    {
        myFilePath = Application.dataPath + "/" + "Texte" + "/" + numeCapitol + "/" + fileName;
        i = 0;
        namesArray = File.ReadAllLines(myFilePath);
        codeBox.text = null;
        while(namesArray[i] != "[spatiu]")
        {
            codeBox.text += '\n' + namesArray[i];
            i++;
        }
        promptBox.text = namesArray[i+1];
        promptBox.text += '\n' + namesArray[i+2];
        int font = int.Parse(namesArray[i+3]);
        ABox.text = namesArray[i+4];
        BBox.text = namesArray[i+5];
        CBox.text = namesArray[i+6];
        DBox.text = namesArray[i+7];
        ABox.fontSize = font;
        BBox.fontSize = font;
        CBox.fontSize = font;
        DBox.fontSize = font;
           
        
       
        
    }
}
