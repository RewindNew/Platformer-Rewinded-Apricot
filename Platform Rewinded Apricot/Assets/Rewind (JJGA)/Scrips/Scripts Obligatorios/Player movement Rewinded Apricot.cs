using UnityEngine;

public class PlayermovementRewindedApricot : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private Rigidbody2D _rigidBody2D;
    [SerializeField] private GroundCheckRwindedApricot _groundCheck;
    [SerializeField] private SpriteRenderer _reflect;

    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (_groundCheck.estaEnSuelo)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _rigidBody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);

                Debug.Log("Oprimí la tecla");
            }
        }



        if (Input.GetKey(KeyCode.D))
        {
            _rigidBody2D.linearVelocity = new Vector2(1 * _movementSpeed, _rigidBody2D.linearVelocity.y);
            _reflect.flipX = false;
        }




        if (Input.GetKey(KeyCode.A))
        {
            _rigidBody2D.linearVelocity = new Vector2(-1 * _movementSpeed, _rigidBody2D.linearVelocity.y);
            _reflect.flipX = true;

        }











    }
}
