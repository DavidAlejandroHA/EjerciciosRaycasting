using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioUno : MonoBehaviour
{
    public int longitudRayo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, transform.up, 45f * Time.deltaTime);

        /* TODO 2: Lanzar un rayo que salga desde el cubo hacia adelante, y que cambie el color del objeto con el que choca */
        Vector3 origen = transform.position;
        Vector3 direccion = transform.forward;

        RaycastHit golpe;
        if (Physics.Raycast(origen, direccion, out golpe))
        {
            Debug.Log(golpe.collider.gameObject.name);
            Destroy(golpe.collider.gameObject);
        }
            
        //Gizmos.DrawRay();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.forward);

        /* TODO 1: Crear un Gizmo que sea una linea con longitud longitudRayo */
    }
}
