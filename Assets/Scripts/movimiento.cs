using UnityEngine;
public class movimiento : MonoBehaviour
{
    private float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(1f, 0f, 0f);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
