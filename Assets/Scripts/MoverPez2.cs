using UnityEngine;

public class MoverPez2 : MonoBehaviour
{
    public float radio = 2f;         // Tamaño del círculo
    public float velocidad = 1f;     // Qué tan rápido da la vuelta
    public Vector3 centro;          // Centro del círculo

    private float angulo;

    void Start()
    {
        // Si no defines un centro, toma la posición inicial como centro
        if (centro == Vector3.zero)
        {
            centro = transform.position;
        }
    }

    void Update()
    {
        angulo += velocidad * Time.deltaTime;

        float x = Mathf.Cos(angulo) * radio;
        float z = Mathf.Sin(angulo) * radio;

        transform.position = new Vector3(centro.x + x, centro.y, centro.z + z);

        // Opcional: que el pez mire hacia el centro mientras gira
        transform.LookAt(centro);
    }
}
