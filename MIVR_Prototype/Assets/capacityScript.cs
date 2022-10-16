using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class capacityScript : MonoBehaviour 
{
    public Image capacityBar; // iniitialize public var
    private ItemWeight itemWeight; // initialize variable of type script

    void setFill(float amount) // function to set fill amount
    {
        capacityBar.fillAmount = amount;
    }

    void Start() // set fill amount to 0 upon game start
    {
        setFill(0);
    }


    private void OnTriggerEnter(Collider other) // function upon collision, add fill to the UI bar
    {
        itemWeight = other.GetComponent<ItemWeight>(); // retrieve component from other script and store in var itemweight
     Debug.Log("Trigger" + itemWeight.Mass); // debug log to make sure mass is being triggered
            
         capacityBar.fillAmount += itemWeight.Mass; // fill the bar by the amount of mass
    }

    private void OnTriggerExit(Collider other)
    {
        itemWeight = other.GetComponent<ItemWeight>();
        Debug.Log("Trigger" + itemWeight.Mass);
        capacityBar.fillAmount -= itemWeight.Mass;
    }

}
