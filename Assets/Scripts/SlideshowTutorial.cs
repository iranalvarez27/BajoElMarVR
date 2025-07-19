using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlideshowTutorial : MonoBehaviour
{
    public Image slideshowImage;                    // Referencia al objeto UI.Image
    public Sprite[] slides;                         // Carga de imágenes
    private int currentSlide = 0;

    void Start()
    {
        MostrarDiapositiva();
    }

    public void Avanzar()
    {
        if (currentSlide < slides.Length - 1)
        {
            currentSlide++;
            MostrarDiapositiva();
        }
    }

    public void Retroceder()
    {
        if (currentSlide > 0)
        {
            currentSlide--;
            MostrarDiapositiva();
        }
    }

    void MostrarDiapositiva()
    {
        slideshowImage.sprite = slides[currentSlide];
    }
}
