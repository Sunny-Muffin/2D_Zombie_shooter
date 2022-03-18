using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExample : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!!!");

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collision Stay");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision EXIT");
    }
    
}
