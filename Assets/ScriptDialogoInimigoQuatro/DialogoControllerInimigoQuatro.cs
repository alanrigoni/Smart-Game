using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoControllerInimigoQuatro : MonoBehaviour
{
    public GameObject PainelDeDialogoInimigoQuatro;

    public Text falainimigoquatro;

    public GameObject respostainimigoquatro;

    private bool falaAtivaInimigoQuatro = false;

    FalaInimigoQuatro falasinimigoquatro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && falaAtivaInimigoQuatro)
        {
            if(falasinimigoquatro.respostasinimigoquatro.Length > 0)
            {
                MostrarRespostasInimigoQuatro();
            }
            else
            {
                falaAtivaInimigoQuatro = false;
                PainelDeDialogoInimigoQuatro.SetActive(false);
            }
        }
    }

    void MostrarRespostasInimigoQuatro()
    {
        falainimigoquatro.gameObject.SetActive(false);
        falaAtivaInimigoQuatro = false;

        for (int i = 0; i < falasinimigoquatro.respostasinimigoquatro.Length; i++)
        {
            GameObject tempRespostaInimigoQuatro = Instantiate(respostainimigoquatro, PainelDeDialogoInimigoQuatro.transform) as GameObject;
            tempRespostaInimigoQuatro.GetComponent<Text>().text = falasinimigoquatro.respostasinimigoquatro[i].respostainimigoquatro;
            tempRespostaInimigoQuatro.GetComponent<AnswerButtonQuatro>().SetupQuatro(falasinimigoquatro.respostasinimigoquatro[i]);
        }
    }

    public void ProximaFalainimigoquatro(FalaInimigoQuatro falaInimigoquatro)
    {
        falasinimigoquatro = falaInimigoquatro;

        LimparRespostasInimigoQuatro();

        falaAtivaInimigoQuatro = true;
        PainelDeDialogoInimigoQuatro.gameObject.SetActive(true);
        falainimigoquatro.gameObject.SetActive(true);

        falainimigoquatro.text = falasinimigoquatro.falaInimigoquatro;
    }

    void LimparRespostasInimigoQuatro()
    {
        AnswerButtonQuatro[] buttons = FindObjectsOfType<AnswerButtonQuatro>();
        foreach (AnswerButtonQuatro button in buttons)
        {
            Destroy(button.gameObject);
        }
    }
}
