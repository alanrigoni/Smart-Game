using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContadorFaseQuatro : MonoBehaviour
{
    public float countdown = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
            SceneManager.LoadScene("FaseQuatro");
        Time.timeScale = 1;
    }
}
