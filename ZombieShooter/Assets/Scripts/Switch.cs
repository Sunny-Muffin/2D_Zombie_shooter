using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour, IInteractable
{
    public Transform tipPoint;
    public GameObject tipCanvas;
    public ElectricBox electricBox;

    //private bool isActive;

    public UnityEvent onSwitch;

    public void HideTip()
    {
        tipCanvas.SetActive(false);
    }

    public void Interact()
    {
        if (electricBox.IsBroken)
        {
            Debug.Log("Repair electric box!");
            return;
        }
        onSwitch?.Invoke();
        //isActive = true;
        Debug.Log("Switch");
    }

    public void ShowTip()
    {
        tipCanvas.SetActive(true);
        tipCanvas.transform.position = tipPoint.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
