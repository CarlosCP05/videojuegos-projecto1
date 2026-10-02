using UnityEngine;

public class EnemyFollowController : MonoBehaviour
{
    private Camera mainCam;
    public float speed = 2F;

    public Transform objetoObjetivo = GameObject.Find("Circle MovNuevo").transform;
    void Start()
    {
        mainCam = Camera.main;
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
        Vector3 movimiento = objetoObjetivo.position - transform.position;
        transform.Translate(movimiento.normalized * speed * Time.deltaTime, Space.World);
    }
}
