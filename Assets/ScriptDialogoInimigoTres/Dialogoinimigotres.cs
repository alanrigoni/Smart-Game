using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogoinimigotres : MonoBehaviour
{
    public FalaInimigoTres[] falasinimigotres = new FalaInimigoTres[2];

    DialogoControllerInimigoTres dialogoContollerInimigoTres;

    private bool dialogoConcluidoinimigotres = false;

    
    // Start is called before the first frame update
    void Start()
    {
        dialogoContollerInimigoTres = FindObjectOfType<DialogoControllerInimigoTres>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo3"))
        {
            
        }
            if (!dialogoConcluidoinimigotres)
            {
                dialogoContollerInimigoTres.ProximaFalainimigotres(falasinimigotres[0]);
            }
            else
            {
                dialogoContollerInimigoTres.ProximaFalainimigotres(falasinimigotres[1]);

            }

            dialogoConcluidoinimigotres = true;

        }
    }

