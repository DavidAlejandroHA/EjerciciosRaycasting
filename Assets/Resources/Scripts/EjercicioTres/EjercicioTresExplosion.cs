using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using Color = UnityEngine.Color;

public class EjercicioTresExplosion : MonoBehaviour
{

    public int radio;
    // Update is called once per frame
    void Update()
    {
        // Esta lista almacenará el resultado de llamar a OverlapSphere
        Collider[] listaChoques;

        /* TODO 1: LLamar al método OverlapShpere */
        int mascara = 1 << 6;
        listaChoques = Physics.OverlapSphere(transform.position, radio, mascara);

       // Debug.Log(listaChoques.Length);


        /* TODO 2: Recorrer la lista de choques */
        /* TODO 3: Aplicar una fuerza de explosion usando el método AddExplosionForce */
        float fuerzaExplosion = 2.0f;

        foreach (Collider choque in listaChoques)
        {
            //Debug.Log(choque.gameObject.name);
            choque.gameObject.GetComponent<Rigidbody>().AddExplosionForce(fuerzaExplosion, transform.position, radio);
        }

        
        //listaChoques.









        /* TODO 3 EXTRA: Aplicar a cada uno de los choques una fuerza usando la normal del choque */
        //        ^ Fuerza Normal     
        //        |
        //        |
        //        |      
        //        |   
        //        |   
        //        |
        // -----------------> Superficie
        // Para calcular el vector normal del choque, usa las funciones ClosestPointOnBounds, para asignar el punto de la esfera más cercano al choque.
        // Con este vector, restale el centro de la esfera, y normalizalo. Ahí tienes el vector normal!


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(255, 192, 203); // Color rosa
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
