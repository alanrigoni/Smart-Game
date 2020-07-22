using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoControllerInimigoSeis : MonoBehaviour
{
    public GameObject PainelDeDialogoInimigoSeis;

    public Text falainimigoseis;

    public GameObject respostainimigoseis;

    private bool falaAtivaInimigoSeis = false;

    FalaInimigoSeis falasinimigoseis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && falaAtivaInimigoSeis)
        {
            if(falasinimigoseis.respostasinimigoseis.Length > 0)
            {
                MostrarRespostasInimigoSeis();
            }
            else
            {
                falaAtivaInimigoSeis = false;
                PainelDeDialogoInimigoSeis.SetActive(false);
            }
        }
    }

    void MostrarRespostasInimigoSeis()
    {
        falainimigoseis.gameObject.SetActive(false);
        falaAtivaInimigoSeis = false;

        for (int i = 0; i < falasinimigoseis.respostasinimigoseis.Length; i++)
        {
            GameObject tempRespostaInimigoSeis = Instantiate(respostainimigoseis, PainelDeDialogoInimigoSeis.transform) as GameObject;
            tempRespostaInimigoSeis.GetComponent<Text>().text = falasinimigoseis.respostasinimigoseis[i].respostainimigoseis;
            tempRespostaInimigoSeis.GetComponent<AnswerButtonSeis>().SetupSeis(falasinimigoseis.respostasinimigoseis[i]);
        }
    }

    public void ProximaFalainimigoseis(FalaInimigoSeis falaInimigoseis)
    {
        falasinimigoseis = falaInimigoseis;

        LimparRespostasInimigoSeis();

        falaAtivaInimigoSeis = true;
        PainelDeDialogoInimigoSeis.gameObject.SetActive(true);
        falainimigoseis.gameObject.SetActive(true);

        falainimigoseis.text = falasinimigoseis.falaInimigoseis;
    }

    void LimparRespostasInimigoSeis()
    {
        AnswerButtonSeis[] buttons = FindObjectsOfType<AnswerButtonSeis>();
        foreach (AnswerButtonSeis button in buttons)
        {
            Destroy(button.gameObject);
        }
    }
}
