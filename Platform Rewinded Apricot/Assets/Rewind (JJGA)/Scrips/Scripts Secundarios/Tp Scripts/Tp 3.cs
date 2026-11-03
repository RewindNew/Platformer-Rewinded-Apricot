using UnityEngine;

public class TeleportScript3 : MonoBehaviour
{
    // Tus coordenadas fijas de destino
    private Vector3 destinoExacto3 = new Vector3(242f, -0.8f, 0f);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Teletransporta al jugador a la ubicación exacta
            collision.transform.position = destinoExacto3;

            // Opcional: Detiene por completo el movimiento del jugador al llegar
            if (collision.TryGetComponent<Rigidbody2D>(out Rigidbody2D rb))
            {
                rb.linearVelocity = Vector2.zero;
            }
        }
    }
}
