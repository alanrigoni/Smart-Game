using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoControllerInimigoDois : MonoBehaviour
{
    public GameObject PainelDeDialogoInimigoDois;

    public Text falainimigodois;

    public GameObject respostainimigodois;

    private bool falaAtivaInimigoDois = false;

    FalaInimigoDois falasinimigodois;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && falaAtivaInimigoDois)
        {
            if(falasinimigodois.respostasinimigodois.Length > 0)
            {
                MostrarRespostasInimigoDois();
            }
            else
            {
                falaAtivaInimigoDois = false;
                PainelDeDialogoInimigoDois.SetActive(false);
            }
        }
    }

    void MostrarRespostasInimigoDois()
    {
        falainimigodois.gameObject.SetActive(false);
        falaAtivaInimigoDois = false;

        for (int i = 0; i < falasinimigodois.respostasinimigodois.Length; i++)
        {
            GameObject tempRespostaInimigoDois = Instantiate(respostainimigodois, PainelDeDialogoInimigoDois.transform) as GameObject;
            tempRespostaInimigoDois.GetComponent<Text>().text = falasinimigodois.respostasinimigodois[i].respostainimigodois;
            tempRespostaInimigoDois.GetComponent<AnswerButtonDois>().SetupDois(falasinimigodois.respostasinimigodois[i]);
        }
    }

    public void ProximaFalainimigodois(FalaInimigoDois falaInimigodois)
    {
        falasinimigodois = falaInimigodois;

        LimparRespostasInimigoDois();

        falaAtivaInimigoDois = true;
        PainelDeDialogoInimigoDois.gameObject.SetActive(true);
        falainimigodois.gameObject.SetActive(true);

        falainimigodois.text = falasinimigodois.falaInimigodois;
    }

    void LimparRespostasInimigoDois()
    {
        AnswerButtonDois[] buttons = FindObjectsOfType<AnswerButtonDois>();
        foreach (AnswerButtonDois button in buttons)
        {
            Destroy(button.gameObject);
        }
    }
}
