using UnityEngine;

public class Wincondition : MonoBehaviour
{
    [SerializeField] private GameManagerRewindedApricot _gameManager;
    [SerializeField] private UIManagerRewindedApricot _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            _gameManager.PausarElJuego();
            _uiManager.Victory();
        
        }

    
    }
}
