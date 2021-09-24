using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public DataSO channel;
    [SerializeField] public float magnitud = 10f, magnitudAngular = 90;
    [SerializeField] string horizontal = "Horizontal", vertical = "Vertical";


    private void OnEnable() {
        channel.OnMovement += Mover;
    }

    private void OnDisable() {
        channel.OnMovement -= Mover;
    }

    void Mover() {
        
        float z = Input.GetAxis(vertical);
        Vector3 velocidad = transform.forward * magnitud * z;
        Vector3 desplazamiento = velocidad * Time.deltaTime;
        transform.position += desplazamiento;

        float x = Input.GetAxis(horizontal);
        Vector3 velocidadAngular = new Vector3(0, 1, 0) * magnitudAngular * x;
        Vector3 desplazamientoAngular = velocidadAngular * Time.deltaTime;
        transform.eulerAngles += desplazamientoAngular;
    }
}
