using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;


    public void Open()
    {
        _animator.SetTrigger("openDoor");
        GetComponent<Collider2D>().enabled = false;
        Debug.Log("Door open!");
    }
}
