using UnityEngine;

public class MoverBote : MonoBehaviour
{
    public float velocidad = 2f;
    public float rotacion = 50f;

    void Update()
    {
        float mover = Input.GetAxis("Vertical");   // Joystick arriba/abajo
        float girar = Input.GetAxis("Horizontal"); // Joystick izquierda/derecha

transform.Translate(transform.forward * mover * velocidad * Time.deltaTime);
        transform.Rotate(Vector3.up * girar * rotacion * Time.deltaTime);
    }
}
