using UnityEngine;
using UnityEngine.UI;

public class ControladorAudio : MonoBehaviour
{
    public Slider volumenSlider;
    public Toggle muteToggle;
    public AudioSource audioFuente; //tu AudioSource real

    private float volumenAnterior = 1f;
    private bool actualizandoDesdeCodigo = false;

    void Start()
    {
        if (audioFuente == null)
        {
            Debug.LogError("AudioSource no asignado en ControladorAudio");
            return;
        }

        // Volumen inicial
        audioFuente.volume = 1f;
        volumenSlider.value = 1f;
        muteToggle.isOn = false;
    }

    public void CambiarVolumen(float nuevoVolumen)
    {
        if (actualizandoDesdeCodigo || audioFuente == null) return;

        audioFuente.volume = nuevoVolumen;

        actualizandoDesdeCodigo = true;
        muteToggle.isOn = nuevoVolumen == 0f;
        actualizandoDesdeCodigo = false;

        if (nuevoVolumen > 0f)
            volumenAnterior = nuevoVolumen;
    }

    public void MutearAudio(bool estaMuteado)
    {
        if (actualizandoDesdeCodigo || audioFuente == null) return;

        actualizandoDesdeCodigo = true;

        if (estaMuteado)
        {
            volumenAnterior = audioFuente.volume > 0f ? audioFuente.volume : 1f;
            audioFuente.volume = 0f;
            volumenSlider.value = 0f;
        }
        else
        {
            audioFuente.volume = volumenAnterior;
            volumenSlider.value = volumenAnterior;
        }

        actualizandoDesdeCodigo = false;
    }
}
