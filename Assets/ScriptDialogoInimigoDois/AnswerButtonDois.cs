using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButtonDois : MonoBehaviour
{
    Respostainimgodois respostaDataDois;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProximaFalainimigodois()
    {
        FindObjectOfType<DialogoControllerInimigoDois>().ProximaFalainimigodois(respostaDataDois.ProximaFalainimigodois);
    }

    public void SetupDois(Respostainimgodois respostainimgodois)
    {
        respostaDataDois = respostainimgodois;
    }
}
