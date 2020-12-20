using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaTrigger : MonoBehaviour
{
    public GameObject button;

    private void Awake()
    {
        button.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            button.SetActive(true);
        }
    }
}
