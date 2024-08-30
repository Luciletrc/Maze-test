using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torche : MonoBehaviour
{
   public GameObject objTorch;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            objTorch.SetActive(!objTorch.activeSelf); // Inverse l'état de la lampe torche
        }
    }
}