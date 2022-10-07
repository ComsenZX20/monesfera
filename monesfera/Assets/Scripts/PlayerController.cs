using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class PlayerController : MonoBehaviour
{
    
    Vector2 direction;
    [SerializeField]
    float impulse = 2f;
    [SerializeField]
    TextMeshProUGUI labelFuel;
    Rigidbody body;
    public float MovimientoEjeX;
    public float MovimientoEjeY;
    public float MovimientoEjeZ;
    public float VelocidadMovimiento = 1.5f;

    // Start is called before the first frame update

    float monedas = 0f;

    [SerializeField]
    GameObject prefabParticles;
    void Start()
    {
        monedas = 100f;
        body = GetComponent<Rigidbody>();

    }
    //añadir fuerza a body hacia la derecha
    // Update is called once per frame
    // Update se ira gastando
    void Update()
    {
        MovimientoEjeX = -Input.GetAxis("Vertical") * Time.deltaTime * VelocidadMovimiento;

        MovimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime * VelocidadMovimiento;



        //para que se mueva usando wasd/flechas o con mando
        //y = Input.GetAxis


        //si la gasolina acaba
        //desactivar componente

        //si gasolina 0 o menos

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Fuel" && monedas > 0.0f)

            monedas = monedas += 10f;

        if (monedas > 100f)
        {
            monedas= 100f;

        }
        
        
        collision.GetComponent<AudioSource>().Play();


        collision.enabled = false;


        //Crear Particulas
        Instantiate(prefabParticles, collision.transform.position, collision.transform.rotation);
        //Destruir
        Destroy(collision.gameObject);

    }
    
    private void FixedUpdate()
    {
        
        

    }
    
}  
