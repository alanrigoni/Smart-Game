using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Lógica botão Começar
    public void BtStart()
    {
        //Foi para a tela de introduções
        SceneManager.LoadScene("Instrucoes");
       
    }

    //Lógica botão Configurar
    public void BtConfig()
    {
        Debug.Log("Foi para a configuração");
        //SceneManager.LoadScene("Configuracao");
    }

    //Lógica botão Sair
    public void BtExit()
    {
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }
}
