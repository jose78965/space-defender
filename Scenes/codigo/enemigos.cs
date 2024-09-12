using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigos : MonoBehaviour
{
    public float speed = 5;
    public GameObject enemigo;  // Prefab del enemigo amarillo
    public float tiempo = 12f;  // Tiempo entre la invocaci�n de nuevos enemigos
    public float x = 10f;  // Rango de posici�n en el eje X
    public float y = 2f;   // Rango de posici�n en el eje Y

    void Start()
    {
        // Repite la generaci�n de enemigos cada 'tiempo' segundos
        InvokeRepeating("GenerarEnemigo", 6f, tiempo);
    }

    void Update()
    {
        // Movimiento horizontal de los enemigos
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GameObject")
        {
            // Mueve al enemigo hacia abajo y cambia la direcci�n
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            speed *= -1;
        }
    }

    private void GenerarEnemigo()
    {
        // Genera una posici�n aleatoria dentro de los l�mites de X e Y
        float posx = Random.Range(-x, x);
        float posy = Random.Range(-y, y);
        Vector2 posicion = new Vector2(posx, posy);

        // Instancia el prefab amarillo en la posici�n generada
        Instantiate(enemigo, posicion, Quaternion.identity);
    }
}
