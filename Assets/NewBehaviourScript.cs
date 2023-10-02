using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Cube;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Button_click()
    {
        if (Cube.activeInHierarchy == true)
            Cube.SetActive(false);
        else
            Cube.SetActive(true);
    }
}
