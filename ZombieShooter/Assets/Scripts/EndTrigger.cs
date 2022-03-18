using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject CompleteLevelUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CompleteLevel();
        }
    }

    private void CompleteLevel ()
    {
        Debug.Log("Finish!");
        CompleteLevelUI.SetActive(true);
    }
}
