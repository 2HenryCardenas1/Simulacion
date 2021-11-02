using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    public float speed = 2;
    public Vector2 direction;

    public int tiempovida = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,tiempovida);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = direction.normalized * speed *Time.deltaTime;

        //transform.position = new Vector2(transform.position.x + movement.x,transform.position.y + movement.y);

        transform.Translate(movement);
    }
}
