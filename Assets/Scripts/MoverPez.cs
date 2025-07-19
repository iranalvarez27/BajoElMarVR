using UnityEngine;

public class MoverPez : MonoBehaviour
{
    public float amplitud = 0.5f; // Que tanto sube y baja
    public float velocidad = 1f;  // Velocidad del movimiento

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        float desplazamiento = Mathf.Sin(Time.time * velocidad) * amplitud;
        transform.position = posicionInicial + new Vector3(0, desplazamiento, 0);
    }
}
