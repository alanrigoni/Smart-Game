using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButtonTres : MonoBehaviour
{
    Respostainimgotres respostaDataTres;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProximaFalainimigotres()
    {
        FindObjectOfType<DialogoControllerInimigoTres>().ProximaFalainimigotres(respostaDataTres.ProximaFalainimigotres);
    }

    public void SetupTres(Respostainimgotres respostainimgotres)
    {
        respostaDataTres = respostainimgotres;
    }
}
