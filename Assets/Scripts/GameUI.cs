using UnityEngine;
using UnityEngine.UIElements;

public class GameUI : MonoBehaviour
{
     private Label vidasTx;
    private Label puntosTx;
    private Label gameOver;
    private Label puntuacion;
    private Label mejorPuntuacion;
    private Button btnVolverMenu;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        vidasTx = root.Q<Label>("VidasTx");
        puntosTx = root.Q<Label>("PuntosTx");
        gameOver = root.Q<Label>("HasPerdido");
        puntuacion = root.Q<Label>("Puntuacion");
        mejorPuntuacion = root.Q<Label>("MejorPuntuacion");
        btnVolverMenu = root.Q<Button>("btnVolverMenu");
        
        gameOver.style.display = DisplayStyle.None;
        puntuacion.style.display = DisplayStyle.None;
        mejorPuntuacion.style.display = DisplayStyle.None;
        btnVolverMenu.style.display = DisplayStyle.None;
    }

    public void ActualizarVidas(int vidas)
    {
        vidasTx.text = "Vidas: " + vidas;
    }

    public void ActualizarPuntos(int puntos)
    {
        puntosTx.text = "Puntos: " + puntos;
    }    

    public void MostrarGameOver(int puntuacionAct, int mejorPuntuacionActual)
    {
        gameOver.style.display = DisplayStyle.Flex;
        puntuacion.style.display = DisplayStyle.Flex;
        mejorPuntuacion.style.display = DisplayStyle.Flex;
        btnVolverMenu.style.display = DisplayStyle.Flex;

        puntuacion.text = "Puntuación: " + puntuacionAct;
        mejorPuntuacion.text = "Mejor puntuación: " + mejorPuntuacionActual;

        btnVolverMenu.clicked += VolverAlMenu;
    }

    void VolverAlMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
