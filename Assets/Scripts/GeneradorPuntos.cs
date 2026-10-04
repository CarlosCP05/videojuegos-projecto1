using UnityEngine;

public class GeneradorPuntos : MonoBehaviour
{
    public GameObject punto;

    void Start()
    {
        InvokeRepeating("CrearPunto", 2f, 3f);
    }

    void CrearPunto()
    {
        float x = Random.Range(-8f, 8f);
        float y = Random.Range(-4f, 4f);

        Instantiate(
            punto,
            new Vector3(x, y, 0),
            Quaternion.identity
        );
    }
}
