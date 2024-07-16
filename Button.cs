using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Interactable
{
    public bool wrong;
    private Door door;
    [SerializeField] private GameObject doorGameObject;
    private void Awake()
    {
        door = doorGameObject.GetComponent<Door>();


    }
    protected override void Interact()
    {
        door.Open();
        door.IsLocked = false;
        if(!wrong)
            FindObjectOfType<AudioManager>().Play("Button");
        else FindObjectOfType<AudioManager>().Play("Wrong");
    }
}
