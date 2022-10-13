using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class capacityScript : MonoBehaviour 
{
    public Image capacityBar; // iniitialize public var
    private ItemWeight itemWeight; //initialize class script

    void setFill(float amount) //set fill amount to 0 
    {
        capacityBar.fillAmount = amount;
    }

    void Start() 
    {
        setFill(0);
    }


    private void OnTriggerEnter(Collider other)
    {
        itemWeight = other.GetComponent<ItemWeight>();
     Debug.Log("Trigger" + itemWeight.Mass);
            
         capacityBar.fillAmount += itemWeight.Mass;
    }

    //private void AddWeight (float amount)
    //{
        //capacityBar.fillAmount += itmeWeight.Mass;
    //}

}
