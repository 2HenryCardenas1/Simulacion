using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorCarreteras : MonoBehaviour
{
    public GameObject contenedorCallesGO;
    public GameObject[] contenedorCallesArray;

    public float velocidad;
    public bool inicioJuego;
    public bool juegoTerminado;

    int contadorCalles = 0;
    int numeroSelectorCalles;

    public GameObject calleAnterior;
    public GameObject calleNueva;

    public float tamanoCalle;

    public Vector3 medidaLimitePantalla;
    public bool salioPantalla;

    //acceder al componente camara
    public GameObject mCamGo;
    //acceder 
    public Camera mCamComp;


    public GameObject cocheGO;
	public GameObject audioFXGO;
	public AudioFX audioFXScript;
	public GameObject bgFinalGO;



    // Start is called before the first frame update
    void Start()
    {
        InicioJuego();
    }

    void InicioJuego()
    {
        contenedorCallesGO = GameObject.Find("ContenedorCalles");

        mCamGo = GameObject.Find("Main Camera");
        mCamComp = mCamGo.GetComponent<Camera>();

        bgFinalGO = GameObject.Find("PanelGameOver");
		bgFinalGO.SetActive(false);

		audioFXGO = GameObject.Find("AudioFX");
		audioFXScript = audioFXGO.GetComponent<AudioFX>();

		cocheGO = GameObject.FindObjectOfType<Coche>().gameObject;


        // Inicializamos_la_velocidad
        VelocidadMotorCarretera();

        MedirPantalla();
        //Llamamos a la funcion BuscarCalles
        BuscarCalles();
    }

    public void JuegoTerminadoEstados()
	{
		cocheGO.GetComponent<AudioSource>().Stop();
		audioFXScript.FXMusic();
		bgFinalGO.SetActive(true);
	}

    void VelocidadMotorCarretera()
    {
        velocidad =  6f;
    }

    // metodo para buscar calles con la etiqueta Calles y almacenarlas en el array
    void BuscarCalles()
    {
        contenedorCallesArray = GameObject.FindGameObjectsWithTag("Calle");

        // Recorro el arreglo de calles , les pongo un nombre las hago hijo del contendor y las pago para quer no se vean en la esena

        for(int i = 0; i < contenedorCallesArray.Length; i++)
        {
            //.parent es para hacer hijo de un gameObject diferente
            contenedorCallesArray[i].gameObject.transform.parent = contenedorCallesGO.transform;
            //Al gameObject que encontro lo apgue y no lo muestre
            contenedorCallesArray[i].gameObject.SetActive(false);
            //Le cambiamos el nombre a la calle
            contenedorCallesArray[i].gameObject.name = "CalleOff_" + i;
        }

        CrearCalle();
    }

    //Encender y posicionar calles alaetoriamente
    void CrearCalle()
    {
        //cada vez que entre en la funcion se incrementa el contador en 1
        contadorCalles++;
        numeroSelectorCalles = Random.Range(0, contenedorCallesArray.Length);
        //Creo alguna de las calles encontradas en el array
        GameObject Calle = Instantiate(contenedorCallesArray[numeroSelectorCalles]);
        //Enciendo la calle seleccionada
        Calle.SetActive(true);
        //La nombro
        Calle.name = "Calle"+contadorCalles;
        //La hago hija del motor de la carretera
        Calle.transform.parent = gameObject.transform;

        PosicionarCalles();
    }

    void PosicionarCalles()
    {
        calleAnterior = GameObject.Find("Calle"+(contadorCalles - 1));
        calleNueva = GameObject.Find("Calle"+contadorCalles);

        //Posicionar
        MedirCalle();
        //Editamos la posicion del vector
        calleNueva.transform.position = new Vector3(calleAnterior.transform.position.x,
            calleAnterior.transform.position.y + tamanoCalle,0);

        salioPantalla = false;
    }

    void MedirCalle()
    {
        //Medimos la altura de la calle con la propiedad 
        //recorremos la cantidad de componentes hijos que tiene nuestra calle
        for(int i = 0; i < calleAnterior.transform.childCount; i++)
        {
            //Si la calle tiene el componente Pieza entonces que me tome la altura de la calle
            if(calleAnterior.transform.GetChild(i).gameObject.GetComponent<Pieza>() != null)
            {
                //.bounds.size es para tomar los valores de x,y o z
                float tamanoPieza = calleAnterior.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
                tamanoCalle = tamanoCalle + tamanoPieza;
            }
            
        }
    }


    void MedirPantalla()
    {
        medidaLimitePantalla = new Vector3(0, mCamComp.ScreenToWorldPoint(new Vector3(0, 0, 0)).y - 0.5f, 0);
    }

    void DestruirCalles()
    {
        Destroy(calleAnterior);
        tamanoCalle = 0;
        calleAnterior = null;
        CrearCalle();
    }

    // Update is called once per frame
    void Update()
    {

        if(inicioJuego == true && juegoTerminado == false)
        { 
        transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        if (calleAnterior.transform.position.y + tamanoCalle < medidaLimitePantalla.y && salioPantalla == false)
          {
                //
                salioPantalla = true;
                //Destruir calles
                DestruirCalles();
            }

        }

       
    }
}
