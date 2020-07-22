using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogoinimigodois : MonoBehaviour
{
    public FalaInimigoDois[] falasinimigodois = new FalaInimigoDois[2];

    DialogoControllerInimigoDois dialogoContollerInimigoDois;

    private bool dialogoConcluidoinimigodois = false;

    
    // Start is called before the first frame update
    void Start()
    {
        dialogoContollerInimigoDois = FindObjectOfType<DialogoControllerInimigoDois>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo2"))
        {
            
        }
            if (!dialogoConcluidoinimigodois)
            {
                dialogoContollerInimigoDois.ProximaFalainimigodois(falasinimigodois[0]);
            }
            else
            {
                dialogoContollerInimigoDois.ProximaFalainimigodois(falasinimigodois[1]);

            }

            dialogoConcluidoinimigodois = true;

        }
    }

