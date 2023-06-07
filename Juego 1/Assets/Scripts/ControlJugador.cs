using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mover la furgoneta hacia delante
        // transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * 15);
    }
}
