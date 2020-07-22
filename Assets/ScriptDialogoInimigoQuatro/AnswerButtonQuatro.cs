using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButtonQuatro : MonoBehaviour
{
    Respostainimgoquatro respostaDataQuatro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProximaFalainimigoquatro()
    {
        FindObjectOfType<DialogoControllerInimigoQuatro>().ProximaFalainimigoquatro(respostaDataQuatro.ProximaFalainimigoquatro);
    }

    public void SetupQuatro(Respostainimgoquatro respostainimgoquatro)
    {
        respostaDataQuatro = respostainimgoquatro;
    }
}
