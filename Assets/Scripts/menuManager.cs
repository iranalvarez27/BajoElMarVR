using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    [Header("Textos")]
    public TextMeshProUGUI titulo;

    [Header("Botones Inicio")]
    public Button btnEmpezar;
    public Button btnAjustes;
    public Button btnSalir;
    [Header("Botones de Retroceso")]
    public Button btnRetrocederAudio;
    public Button btnRetrocederControles;


    [Header("Botones Ajustes")]
    public Button btnAudio;
    public Button btnControles;
    public Button btnVolver;

    [Header("Controles de Audio Directos")]
    public Slider sliderVolumen;

    [Header("Opciones Controles")]
    public GameObject opcionesControles;

    void Start()
    {
        MostrarInicio();
    }

    public void MostrarInicio()
    {
        titulo.text = "DEBAJO DEL MAR VR";
        btnRetrocederAudio.gameObject.SetActive(false);
        btnRetrocederControles.gameObject.SetActive(false);
        btnEmpezar.gameObject.SetActive(true);
        btnAjustes.gameObject.SetActive(true);
        btnSalir.gameObject.SetActive(true);

        btnVolver.gameObject.SetActive(false);
        btnAudio.gameObject.SetActive(false);
        btnControles.gameObject.SetActive(false);

        sliderVolumen.gameObject.SetActive(false);
        opcionesControles.SetActive(false);
    }

    public void Empezar()
    {
        SceneManager.LoadScene("Escena1");
    }

    public void MostrarAjustes()
    {
        titulo.text = "AJUSTES";

        btnEmpezar.gameObject.SetActive(false);
        btnAjustes.gameObject.SetActive(false);
        btnSalir.gameObject.SetActive(false);

        btnAudio.gameObject.SetActive(true);
        btnControles.gameObject.SetActive(true);
        btnVolver.gameObject.SetActive(true);

        sliderVolumen.gameObject.SetActive(false);
        opcionesControles.SetActive(false);
    }

    public void MostrarAudio()
    {
        titulo.text = "AUDIO";

        btnEmpezar.gameObject.SetActive(false);
        btnAjustes.gameObject.SetActive(false);
        btnSalir.gameObject.SetActive(false);

        btnAudio.gameObject.SetActive(false);
        btnControles.gameObject.SetActive(false);
        btnVolver.gameObject.SetActive(false);

        sliderVolumen.gameObject.SetActive(true);
        opcionesControles.SetActive(false);
    }

    public void MostrarControles()
    {
        titulo.text = "CONTROLES";

        btnEmpezar.gameObject.SetActive(false);
        btnAjustes.gameObject.SetActive(false);
        btnSalir.gameObject.SetActive(false);

        btnAudio.gameObject.SetActive(false);
        btnControles.gameObject.SetActive(false);
        btnVolver.gameObject.SetActive(true);

        sliderVolumen.gameObject.SetActive(false);
        opcionesControles.SetActive(true);
    }

    public void VolverDeAjustes()
    {
        MostrarInicio();
    }
    public void VolverAMenuAjustes()
    {
        MostrarAjustes();
    }
    public void VolverAMenuControles()
    {
        MostrarAjustes();
    }
    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}