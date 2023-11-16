using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoCamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LanzarRayoCamara();
    }

    void LanzarRayoCamara()
    {
        // funcion que devuelve verdadero cuando se pulsa el boton del raton
        if (Input.GetMouseButtonDown(0))
        {
            // Generar un rayo desde la pos del curson del raton
            // hacia el espacio del juego
            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit golpe;
            if (Physics.Raycast(rayoCamara, out golpe))
            {
                Debug.Log(golpe.collider.gameObject.name);
            }
        }
    }
}
