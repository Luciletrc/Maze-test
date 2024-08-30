using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public int[] password;
    public int findPassword = 0;
    
    void Start()
    {
        password = GeneratePasseword();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Indice"))
        {
            other.gameObject.SetActive(false);
            findPassword++;
        }
    }

    int[] GeneratePasseword()
    {
        int[] arr = new int[4];

        for (int i = 0; i < 4; i++)
        {
            arr[i] = Random.Range(0, 9);
        }
        return arr;
    }

}
