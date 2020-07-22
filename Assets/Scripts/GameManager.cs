using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public GameObject PainelCompleto;

    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void FixedUpdate()
    {
        Pause();
    }

    public void Pause() {

        if (Input.GetKeyDown(KeyCode.P))
        {
            PainelCompleto.SetActive(true);
            isPaused = true;
            Time.timeScale = 0;
        }
        else
        {
            PainelCompleto.SetActive(false);
            isPaused = false;
            Time.timeScale = 1;
        }
    }

    //Lógica botão Continuar
    public void BtContinuarPause()
    {
        Time.timeScale = 1;
    }


    //Lógica botão Sair
    public void BtSairPause()
    {
        Debug.Log("Saiu do jogo");
        SceneManager.LoadScene("Menu");

    }
}