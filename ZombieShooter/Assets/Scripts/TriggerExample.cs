using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Enter!");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Trigger Stay!");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger Exit!");
    }
}
