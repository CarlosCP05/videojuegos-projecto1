using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerAntiguo : MonoBehaviour
{
    private float speed = 5F;
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal = A / D + Flechas Izquierda / Derecha
        float horizontal = Input.GetAxis("Horizontal");
        // Vertical = W/S + Flechas Arriba/Abajo
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        // Normalizamos para que no corra más rápido en diagonal
        if (movement.magnitude > 1)
            movement.Normalize();
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

    }
}
