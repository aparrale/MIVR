using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class capacityScript : MonoBehaviour 
{
    public Image capacityBar; // iniitialize public var

    void Start() 
    {
        setFill(0);
    }

    public void setFill(float amount) //set fill amount to 0 
    {
        capacityBar.fillAmount = amount;
    }

    private void OnTriggerEnter(Collider other)
    {
     Debug.Log("Trigger" + ItemWeight.Mass);   
    }

}
