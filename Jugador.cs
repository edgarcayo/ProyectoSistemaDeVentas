using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Permite jugar con la sentencia del nivel

public class Jugador : MonoBehaviour{
    public Rigidbody2D cuerpo;
    public float velocidad;
    public float altura;
    public GameObject RecArrb;
    public GameObject RecAbj;

    void Start()  {
        cuerpo = GetComponent<Rigidbody2D>();
        ConstruirNivel();

    }
    public void ConstruirNivel()
    {
        Instantiate(RecArrb, new Vector3(10, 8), transform.rotation);
        Instantiate(RecAbj, new Vector3(10, -8), transform.rotation);

        Instantiate(RecArrb, new Vector3(17, 6), transform.rotation);
        Instantiate(RecAbj, new Vector3(17, -10), transform.rotation);

        Instantiate(RecArrb, new Vector3(24, 10), transform.rotation);
        Instantiate(RecAbj, new Vector3(24, -8), transform.rotation);

    }
    // Update is called once per frame
    void Update()
    {
        cuerpo.velocity = new Vector2(velocidad, cuerpo.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            cuerpo.velocity = new Vector2(cuerpo.velocity.x, altura);
        }
        // para que el jugador no pase el limite
        if (transform.position.y > 13 || transform.position.y < -13)
        {
            Reinicio(); // se perdenemos,Se va a reninciar
        }
    }
    public void Reinicio()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
