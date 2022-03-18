using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private IInteractable interactable;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactable = collision.GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactable.ShowTip();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            interactable.HideTip();
            interactable = null;
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (interactable != null)
                interactable.Interact();
        }
    }
}
