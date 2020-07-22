using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButtonCinco : MonoBehaviour
{
    Respostainimgocinco respostaDataCinco;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProximaFalainimigocinco()
    {
        FindObjectOfType<DialogoControllerInimigoCinco>().ProximaFalainimigocinco(respostaDataCinco.ProximaFalainimigocinco);
    }

    public void SetupCinco(Respostainimgocinco respostainimgocinco)
    {
        respostaDataCinco = respostainimgocinco;
    }
}
