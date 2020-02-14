using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectAbj : MonoBehaviour
{
    //Crear variables
    private Jugador Jugador;
    public GameObject RecArrb;
    // Start is called before the first frame update
    void Start()
    {
        Jugador = FindObjectOfType<Jugador>();  // encontrar el personaje 

    }

    // Update is called once per frame
    void Update()
    {
        // cada vez que el jugador avance se creen nuevos rectangulos
        if (Jugador.transform.position.x - transform.position.x > 12)
        {
            float yRandom = Random.Range(-4, 4);
            float RandomEspacio = Random.Range(0, 3);

            Instantiate(gameObject, new Vector2(Jugador.transform.position.x + 10, -7 + yRandom), transform.rotation); // rectangulo de abajo
            Instantiate(RecArrb, new Vector2(Jugador.transform.position.x + 10, 7 + yRandom + RandomEspacio), transform.rotation); // rectangulo de arriba
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jugador.Reinicio();
    }
}
