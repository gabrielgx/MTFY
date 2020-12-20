using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject mesaTrigger;
    private int itensColetados;
    private bool isPaused;
    public GameObject painelDeItens;
    void Awake()
    {
        itensColetados = 0;
    }

    private void Start()
    {
        Time.timeScale = 0;
        isPaused = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(itensColetados == 4)
        {
            mesaTrigger.SetActive(true);
            painelDeItens.SetActive(false);
        }
    }


    public void SetItensColetados()
    {
        itensColetados++;
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        painelDeItens.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
    }
}