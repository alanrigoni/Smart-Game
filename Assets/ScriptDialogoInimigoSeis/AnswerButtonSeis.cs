using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButtonSeis : MonoBehaviour
{
    Respostainimgoseis respostaDataSeis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProximaFalainimigoseis()
    {
        FindObjectOfType<DialogoControllerInimigoSeis>().ProximaFalainimigoseis(respostaDataSeis.ProximaFalainimigoseis);
    }

    public void SetupSeis(Respostainimgoseis respostainimgoseis)
    {
        respostaDataSeis = respostainimgoseis;
    }
}
