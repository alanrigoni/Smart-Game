using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoControllerInimigoCinco : MonoBehaviour
{
    public GameObject PainelDeDialogoInimigoCinco;

    public Text falainimigocinco;

    public GameObject respostainimigocinco;

    private bool falaAtivaInimigoCinco = false;

    FalaInimigoCinco falasinimigocinco;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && falaAtivaInimigoCinco)
        {
            if(falasinimigocinco.respostasinimigocinco.Length > 0)
            {
                MostrarRespostasInimigoCinco();
            }
            else
            {
                falaAtivaInimigoCinco = false;
                PainelDeDialogoInimigoCinco.SetActive(false);
            }
        }
    }

    void MostrarRespostasInimigoCinco()
    {
        falainimigocinco.gameObject.SetActive(false);
        falaAtivaInimigoCinco = false;

        for (int i = 0; i < falasinimigocinco.respostasinimigocinco.Length; i++)
        {
            GameObject tempRespostaInimigoCinco = Instantiate(respostainimigocinco, PainelDeDialogoInimigoCinco.transform) as GameObject;
            tempRespostaInimigoCinco.GetComponent<Text>().text = falasinimigocinco.respostasinimigocinco[i].respostainimigocinco;
            tempRespostaInimigoCinco.GetComponent<AnswerButtonCinco>().SetupCinco(falasinimigocinco.respostasinimigocinco[i]);
        }
    }

    public void ProximaFalainimigocinco(FalaInimigoCinco falaInimigocinco)
    {
        falasinimigocinco = falaInimigocinco;

        LimparRespostasInimigoCinco();

        falaAtivaInimigoCinco = true;
        PainelDeDialogoInimigoCinco.gameObject.SetActive(true);
        falainimigocinco.gameObject.SetActive(true);

        falainimigocinco.text = falasinimigocinco.falaInimigocinco;
    }

    void LimparRespostasInimigoCinco()
    {
        AnswerButtonCinco[] buttons = FindObjectsOfType<AnswerButtonCinco>();
        foreach (AnswerButtonCinco button in buttons)
        {
            Destroy(button.gameObject);
        }
    }
}
