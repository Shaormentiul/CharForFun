using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    
    public float transitionTime = 1f;
    public Animator transition;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("`"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }   
    }

    public void LoadNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        else 
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

    }
}
