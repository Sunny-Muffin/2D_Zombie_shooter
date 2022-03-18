using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricBox : MonoBehaviour, IInteractable
{
    public Transform tipPoint;

    public GameObject tipCanvas;

    private bool isBroken = true;

    public bool IsBroken
    {
        get
        {
            return isBroken;
        }
    }

    public void HideTip()
    {
        tipCanvas.SetActive(false);
    }

    public void Interact()
    {
        isBroken = false;
        Debug.Log("Electric");
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
