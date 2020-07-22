using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoController : MonoBehaviour
{
    public GameObject PainelDeDialogo;

    public Text FalaInimigoUm;

    public GameObject resposta;

    private bool falaAtiva = false;

    FalaInimigoUm falas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && falaAtiva)
        {
            if (falas.respostas.Length > 0)
                MostrarRespostas();
            else
            {
                falaAtiva = false;
                PainelDeDialogo.SetActive(false);
            }
        }


    }

    void MostrarRespostas()
    {
        FalaInimigoUm.gameObject.SetActive(false);
        falaAtiva = false;

        for (int i = 0; i < falas.respostas.Length; i++)
        {
            GameObject tempResposta = Instantiate(resposta, PainelDeDialogo.transform) as GameObject;
            tempResposta.GetComponent<Text>().text = falas.respostas[i].resposta;
            tempResposta.GetComponent<AnswerButton>().Setup (falas.respostas[i]);
        }
    }

    public void ProximaFala (FalaInimigoUm fala)
    {
        falas = fala;

        LimparRespostas();

        falaAtiva = true;
        PainelDeDialogo.SetActive(true);
        FalaInimigoUm.gameObject.SetActive(true);

        FalaInimigoUm.text = falas.fala;
    }
    void LimparRespostas()
    {
        AnswerButton[] buttons = FindObjectsOfType<AnswerButton>();
        foreach (AnswerButton button in buttons)
        {
            Destroy(button.gameObject);
        }
    }
}
