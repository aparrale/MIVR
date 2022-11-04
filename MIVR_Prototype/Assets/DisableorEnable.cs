using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableorEnable : MonoBehaviour
{
    public GameObject canvas;

    public void whenButtonclicked()
    {
        if (canvas.activeInHierarchy == true)
            canvas.SetActive(false);
        else
            canvas.SetActive(true);
    }

}
