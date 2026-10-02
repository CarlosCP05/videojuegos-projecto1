using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Camera mainCam;
    public float speed = 0.5F;
    private float horizontal = 0F;
    private float vertical = 0F;
    private float timer = 0F;
    private float siguiente = 0F;
    void Start()
    {
        mainCam = Camera.main;
        PickNewDirection();
        StartCoroutine(CambiarDireccion());
    }
    void KeepInsideCamera()
    {
        // Convertir posición a viewport (0..1)
        Vector3 viewportPos = mainCam.WorldToViewportPoint(transform.position);
        // Clamp para que quede dentro de la cámara
        viewportPos.x = Mathf.Clamp(viewportPos.x, 0.05f, 0.95f);
        viewportPos.y = Mathf.Clamp(viewportPos.y, 0.05f, 0.95f);   
        // Convertir de nuevo a coordenadas del mundo
        transform.position = mainCam.ViewportToWorldPoint(viewportPos);
    }
    void Update()
    {
        KeepInsideCamera();
        Vector3 movimiento = new Vector3(horizontal, vertical, 0f);
        transform.Translate(movimiento * speed * Time.deltaTime, Space.World);
    }
    
    void PickNewDirection()
    {
        horizontal = Random.Range(-5, 5);
        vertical = Random.Range(-5, 5);        
    }

    IEnumerator CambiarDireccion()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3f, 10f));
            PickNewDirection();
            CambiarDireccion();
        }
    }

}
