using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_movimiento_jugador : MonoBehaviour
{
   public float MovimientoEjeX;
   public float MovimientoEjeY;
    public float MovimientoEjeZ;
    public float VelocidadMovimiento = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        //funcion que permitirá el movimiento del personaje.
        MovimientoEjeX = Input.GetAxis("Vertical") * Time.deltaTime * VelocidadMovimiento;

        MovimientoEjeZ = -Input.GetAxis("Horizontal") * Time.deltaTime * VelocidadMovimiento;

        transform.Translate(MovimientoEjeX, MovimientoEjeY, MovimientoEjeZ);  
    }
}
