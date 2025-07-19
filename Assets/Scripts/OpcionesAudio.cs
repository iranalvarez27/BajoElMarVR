using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpcionesAudio : MonoBehaviour
{
    public TMP_Dropdown dropdownMusica;
    public Slider sliderVolumen;
    public AudioSource musicaFondo;

    void Start()
    {
        // Inicializar con valores actuales
        dropdownMusica.onValueChanged.AddListener(ActualizarMusica);
        sliderVolumen.onValueChanged.AddListener(ActualizarVolumen);

        // (Opcional) valores por defecto
        dropdownMusica.value = 0; // 0: Sí, 1: No
        sliderVolumen.value = musicaFondo.volume;
    }

    void ActualizarMusica(int opcion)
    {
        musicaFondo.mute = (opcion == 1); // 1 = No → mute
    }

    void ActualizarVolumen(float valor)
    {
        musicaFondo.volume = valor;
    }
}
