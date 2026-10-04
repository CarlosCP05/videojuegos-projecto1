using UnityEngine;

public class Punto : MonoBehaviour
{
    public int puntos = 3;

    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<Puntuacion>().SumarPuntos(puntos);

            Destroy(gameObject);
        }
    }
}
