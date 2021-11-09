using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public float velocidad =1;
    public float minX ;
    public float maxX;
    public float Tiempoespera = 2;


    private GameObject objetivo;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarObj();
        StartCoroutine("Enemigo_Objetivo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void ActualizarObj()
    {
        if (objetivo == null)
        {
            objetivo = new GameObject("Target");

            objetivo.transform.position = new Vector2(minX,transform.position.y);

            transform.localScale = new Vector3(-1,1,1);
            return;
        }

        if(objetivo.transform.position.x  == minX)
        {
            objetivo.transform.position = new Vector2(maxX,transform.position.y);
            transform.localScale = new Vector3(1,1,1);
        }

        else if(objetivo.transform.position.x == maxX)
        {
            objetivo.transform.position = new Vector2(minX,transform.position.y);
            transform.localScale = new Vector3(-1,1,1);
        }
    }


    private IEnumerator Enemigo_Objetivo()
    {
        while(Vector2.Distance(transform.position,objetivo.transform.position) > 0.05)
        {
            Vector2 direction = objetivo.transform.position -  transform.position;
            float xDirection = direction.x;
            transform.Translate(direction.normalized * velocidad * Time.deltaTime);

            yield return null;
        }

        Debug.Log("Objetivo alcanzado");
        transform.position = new Vector2(objetivo.transform.position.x,transform.position.y);

        Debug.Log("Esperando"+Tiempoespera+"segundos");
        yield return new WaitForSeconds(Tiempoespera);


        Debug.Log("Espero acabó, actualizando objetivo y continuando... ");
        ActualizarObj();
        StartCoroutine("Enemigo_Objetivo");
    }
}
