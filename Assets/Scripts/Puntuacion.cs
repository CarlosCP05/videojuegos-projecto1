using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public int puntos = 0;
    public GameUI gameUI;

    void Start()
    {
        gameUI.ActualizarPuntos(puntos);
        InvokeRepeating("SumarPuntoSegundo", 1f, 1f);

    }

    void SumarPuntoSegundo()
    {
        SumarPuntos();
    }

    public void SumarPuntos(int cantidad = 1)
    {
        puntos += cantidad;

        gameUI.ActualizarPuntos(puntos);
    }
    
    public int ObtenerMejorPuntuacion()
    {
        return PlayerPrefs.GetInt("MejorPuntuacion", 0);
    }

    public void GuardarPuntuacion()
    {
        int mejorPuntuacion = ObtenerMejorPuntuacion();

        if (puntos > mejorPuntuacion)
        {
            PlayerPrefs.SetInt("MejorPuntuacion", puntos);
            PlayerPrefs.Save();
        }
    }
}
