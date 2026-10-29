using UnityEngine;

public class TeleportScript2 : MonoBehaviour
{
    // Tus coordenadas fijas de destino
    private Vector3 destinoExacto2 = new Vector3(159f, 0.7f, 0f);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Teletransporta al jugador a la ubicación exacta
            collision.transform.position = destinoExacto2;

            // Opcional: Detiene por completo el movimiento del jugador al llegar
            if (collision.TryGetComponent<Rigidbody2D>(out Rigidbody2D rb))
            {
                rb.linearVelocity = Vector2.zero;
            }
        }
    }
}
