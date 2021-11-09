using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    public float speed = 2;
    public Vector2 direction;

    public Color colorInicial = Color.white;
    public Color colorFinal;
    private SpriteRenderer rend;
    private float tiempoInicial;

    public int tiempovida = 3;

    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,tiempovida);
        tiempoInicial = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = direction.normalized * speed *Time.deltaTime;

        //transform.position = new Vector2(transform.position.x + movement.x,transform.position.y + movement.y);

        transform.Translate(movement);

        float tiempoTranscurido = Time.time - tiempoInicial;
        float porCompletado = tiempoTranscurido /   tiempovida;
        rend.color = Color.Lerp(colorInicial,colorFinal,porCompletado);


    }
}
