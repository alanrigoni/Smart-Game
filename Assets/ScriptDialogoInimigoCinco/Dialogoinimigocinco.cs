using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogoinimigocinco : MonoBehaviour
{
    public FalaInimigoCinco[] falasinimigocinco = new FalaInimigoCinco[2];

    DialogoControllerInimigoCinco dialogoContollerInimigoCinco;

    private bool dialogoConcluidoinimigocinco = false;

    
    // Start is called before the first frame update
    void Start()
    {
        dialogoContollerInimigoCinco = FindObjectOfType<DialogoControllerInimigoCinco>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo5"))
        {
            
        }
            if (!dialogoConcluidoinimigocinco)
            {
                dialogoContollerInimigoCinco.ProximaFalainimigocinco(falasinimigocinco[0]);
            }
            else
            {
                dialogoContollerInimigoCinco.ProximaFalainimigocinco(falasinimigocinco[1]);

            }

            dialogoConcluidoinimigocinco = true;

        }
    }

