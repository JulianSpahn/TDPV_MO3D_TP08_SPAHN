using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Behaviour : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float velocidadRotacion = 2f;

    void Update()
    {
        // Movimiento hacia adelante y atras
        float movimientoVertical = Input.GetAxis("Vertical") * velocidadMovimiento * Time.deltaTime;
        transform.Translate(Vector3.forward * movimientoVertical);

        // Movimiento lateral
        float movimientoHorizontal = Input.GetAxis("Horizontal") * velocidadMovimiento * Time.deltaTime;
        transform.Translate(Vector3.right * movimientoHorizontal);

        // Rotacion para mirar hacia arriba y abajo
        float rotacionVertical = Input.GetAxis("Mouse Y") * velocidadRotacion;
        transform.Rotate(Vector3.left * rotacionVertical);

        // Rotacion para mirar hacia los lados
        float rotacionHorizontal = Input.GetAxis("Mouse X") * velocidadRotacion;
        transform.Rotate(Vector3.up * rotacionHorizontal);
    }
}
