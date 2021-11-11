using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armas : MonoBehaviour
{

    public GameObject prefabsBalas;
    private Transform PuntoDisparo;
    public GameObject tirador;

    private void Awake(){
        PuntoDisparo = transform.Find("PuntoDisparo");
    }


    public void Disparo()
    {
        if(prefabsBalas != null && PuntoDisparo != null && tirador != null )
        {
            GameObject myBullet = Instantiate(prefabsBalas,PuntoDisparo.position, Quaternion.identity) as GameObject;

            Balas bulletComponent = myBullet.GetComponent<Balas>();

            if(tirador.transform.localScale.x < 0 )
            {
                bulletComponent.direction = Vector2.left;   
            }
            else 
            {
                bulletComponent.direction = Vector2.right;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //Disparo();
       // Invoke("Disparo",1);
       // Invoke("Disparo",2);
        //Invoke("Disparo",3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
