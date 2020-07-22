using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogoinimigoquatro : MonoBehaviour
{
    public FalaInimigoQuatro[] falasinimigoquatro = new FalaInimigoQuatro[2];

    DialogoControllerInimigoQuatro dialogoContollerInimigoQuatro;

    private bool dialogoConcluidoinimigoquatro = false;

    
    // Start is called before the first frame update
    void Start()
    {
        dialogoContollerInimigoQuatro = FindObjectOfType<DialogoControllerInimigoQuatro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo4"))
        {
            
        }
            if (!dialogoConcluidoinimigoquatro)
            {
                dialogoContollerInimigoQuatro.ProximaFalainimigoquatro(falasinimigoquatro[0]);
            }
            else
            {
                dialogoContollerInimigoQuatro.ProximaFalainimigoquatro(falasinimigoquatro[1]);

            }

            dialogoConcluidoinimigoquatro = true;

        }
    }

