using UnityEngine;
using System.Collections;

public class ColisionEnemigo : MonoBehaviour
{
    public float tiempoInvulnerable = 1f;

    private float siguienteDaño = 0f;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if (Time.time >= siguienteDaño)
            {
                GetComponent<Vidas>().PerderVida(1);
                siguienteDaño = Time.time + tiempoInvulnerable;

                StartCoroutine(Parpadear());
            }
        }
    }

    IEnumerator Parpadear()
    {
        float tiempo = 0f;

        while (tiempo < tiempoInvulnerable)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;

            yield return new WaitForSeconds(0.1f);

            tiempo += 0.1f;
        }

        spriteRenderer.enabled = true;
    }
}
