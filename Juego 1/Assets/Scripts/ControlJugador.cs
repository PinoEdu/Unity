using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad = 20.0f;
    public float velocidadGiro = 5;
    public float controlHorizontal;
    public float controlAvance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controlHorizontal = Input.GetAxis("Horizontal");
        controlAvance = Input.GetAxis("Vertical");
        //Mover la furgoneta hacia delante
        // transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * controlAvance);
        transform.Translate(Vector3.right * Time.deltaTime * velocidadGiro * controlHorizontal);
    }
}
