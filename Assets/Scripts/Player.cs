using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float forcaPulo;
    public float velocidadeMaxima;
    public int cristais;

    public Text TextCristais;

    public bool IsGrounded;
    public bool canFly;

    public float countdown = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        TextCristais.text = cristais.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //Intancia o componente Rigidbody2D na variável rigidbody
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        float movimento = Input.GetAxis("Horizontal");

        //Velocidade do personagem
        rigidbody.velocity = new Vector2(movimento * velocidadeMaxima,rigidbody.velocity.y);

        //Andar para trás
        if (movimento < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        //Andar para frente
        else if (movimento > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        //Animãção de Andando
        if (movimento > 0 || movimento < 0)
        {
            GetComponent<Animator>().SetBool("walking", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("walking", false);
        }

        //Para Pular
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsGrounded)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forcaPulo));
                GetComponent<AudioSource>().Play();
                canFly = false;
            }
            else
            {
                canFly = true;
            }
        }

        //Lógica para voar
        
        if (canFly && Input.GetKey(KeyCode.Space) && countdown > 0.0f)
        {
            countdown -= Time.deltaTime;
            //Voando
            GetComponent<Animator>().SetBool("flying", true);
            rigidbody.velocity = new Vector2(rigidbody.velocity.x,+2.5f);
        }
        else {
            GetComponent<Animator>().SetBool("flying", false);
          
            
        }

        //Se está no chão
        if (IsGrounded)
        {
            canFly = false;
            countdown = 1.0f;
            GetComponent<Animator>().SetBool("jumping", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("jumping", true);
        }

    }


    //Pegar Cristais
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Cristais"))
        {
            Destroy(collision2D.gameObject);
            cristais++;
            TextCristais.text = cristais.ToString();
        }
    }


    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Inimigos"))
        {
            //Lógica para Errar a questão e voltar o checkpoint
        }

        if (collision2D.gameObject.CompareTag("Portal"))
        {
            //Lógica para encostar no portal e ir para a tela de carregamento
            SceneManager.LoadScene("CarregarFaseDois");

        }

        if (collision2D.gameObject.CompareTag("Portal2"))
        {
            //Lógica para encostar no portal e ir para a proxima fase
            SceneManager.LoadScene("CarregarFaseTres");

        }

        if (collision2D.gameObject.CompareTag("Portal3"))
        {
            //Lógica para encostar no portal e ir para a proxima fase
            SceneManager.LoadScene("CarregarFaseQuatro");

        }

        if (collision2D.gameObject.CompareTag("Portal4"))
        {
            //Lógica para encostar no portal e ir para a proxima fase
            SceneManager.LoadScene("CarregarFaseCinco");

        }

        if (collision2D.gameObject.CompareTag("Portal5"))
        {
            //Lógica para encostar no portal e ir para a proxima fase
            SceneManager.LoadScene("CarregarFaseSeis");

        }

        if (collision2D.gameObject.CompareTag("Portal6"))
        {
            //Lógica para encostar no portal e ir para os creditos
            SceneManager.LoadScene("CarregarCreditos");

        }

        if (collision2D.gameObject.CompareTag("Plataformas"))
        {
            //Lógica para colidir com plataformas
            IsGrounded = true;
        }

        if (collision2D.gameObject.CompareTag("BlocoEspinhos"))
        {
            //Lógica para voltar o checkpoint depois de encostar no BlocoEspinhos
            this.transform.position = GameObject.FindGameObjectWithTag("Start").transform.position;
        }

        if (collision2D.gameObject.CompareTag("Espinhos"))
        {
            //Lógica para voltar o checkpoint depois de encostar nos espinhos
           
            this.transform.position = GameObject.FindGameObjectWithTag("Start").transform.position;
            
        }    

    }


    void OnCollisionExit2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Plataformas"))
        {
            //Lógica para colidir com plataformas
            IsGrounded = false;
        }
    }
}
