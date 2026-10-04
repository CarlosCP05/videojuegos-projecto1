using UnityEngine;

public class Vidas : MonoBehaviour
{
    public int vidas = 3;
    public GameUI gameUI;
    public Puntuacion puntuacion;

    private bool gameOver = false;

    void Start()
    {
        gameUI.ActualizarVidas(vidas);
    }

    public void PerderVida(int cantidad)
    {
        if (gameOver)
            return;

        vidas -= cantidad;

        gameUI.ActualizarVidas(vidas);

        if (vidas <= 0)
        {
            gameOver = true;

            puntuacion.GuardarPuntuacion();

            gameUI.MostrarGameOver(
                puntuacion.puntos,
                puntuacion.ObtenerMejorPuntuacion()
            );
        }
    }
}
