using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogoinimigoseis : MonoBehaviour
{
    public FalaInimigoSeis[] falasinimigoseis = new FalaInimigoSeis[2];

    DialogoControllerInimigoSeis dialogoContollerInimigoSeis;

    private bool dialogoConcluidoinimigoseis = false;

    
    // Start is called before the first frame update
    void Start()
    {
        dialogoContollerInimigoSeis = FindObjectOfType<DialogoControllerInimigoSeis>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo6"))
        {
            
        }
            if (!dialogoConcluidoinimigoseis)
            {
                dialogoContollerInimigoSeis.ProximaFalainimigoseis(falasinimigoseis[0]);
            }
            else
            {
                dialogoContollerInimigoSeis.ProximaFalainimigoseis(falasinimigoseis[1]);

            }

            dialogoConcluidoinimigoseis = true;

        }
    }

