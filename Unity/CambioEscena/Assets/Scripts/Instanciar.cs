using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    public GameObject prefab;
    public Transform punt;
    public float tiempovida;

    public void Instantiate()
    {
        GameObject instanciarObj = Instantiate(prefab,punt.position,Quaternion.identity) as GameObject;
        if (tiempovida  > 0 ){
            Destroy(instanciarObj,tiempovida);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
