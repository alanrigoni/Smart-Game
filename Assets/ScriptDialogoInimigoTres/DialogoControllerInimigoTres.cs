using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoControllerInimigoTres : MonoBehaviour
{
    public GameObject PainelDeDialogoInimigoTres;

    public Text falainimigotres;

    public GameObject respostainimigotres;

    private bool falaAtivaInimigoTres = false;

    FalaInimigoTres falasinimigotres;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && falaAtivaInimigoTres)
        {
            if(falasinimigotres.respostasinimigotres.Length > 0)
            {
                MostrarRespostasInimigoTres();
            }
            else
            {
                falaAtivaInimigoTres = false;
                PainelDeDialogoInimigoTres.SetActive(false);
            }
        }
    }

    void MostrarRespostasInimigoTres()
    {
        falainimigotres.gameObject.SetActive(false);
        falaAtivaInimigoTres = false;

        for (int i = 0; i < falasinimigotres.respostasinimigotres.Length; i++)
        {
            GameObject tempRespostaInimigoTres = Instantiate(respostainimigotres, PainelDeDialogoInimigoTres.transform) as GameObject;
            tempRespostaInimigoTres.GetComponent<Text>().text = falasinimigotres.respostasinimigotres[i].respostainimigotres;
            tempRespostaInimigoTres.GetComponent<AnswerButtonTres>().SetupTres(falasinimigotres.respostasinimigotres[i]);
        }
    }

    public void ProximaFalainimigotres(FalaInimigoTres falaInimigotres)
    {
        falasinimigotres = falaInimigotres;

        LimparRespostasInimigoTres();

        falaAtivaInimigoTres = true;
        PainelDeDialogoInimigoTres.gameObject.SetActive(true);
        falainimigotres.gameObject.SetActive(true);

        falainimigotres.text = falasinimigotres.falaInimigotres;
    }

    void LimparRespostasInimigoTres()
    {
        AnswerButtonTres[] buttons = FindObjectsOfType<AnswerButtonTres>();
        foreach (AnswerButtonTres button in buttons)
        {
            Destroy(button.gameObject);
        }
    }
}
