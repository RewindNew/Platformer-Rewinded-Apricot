using UnityEngine;

public class DeadlyTrapRewindedApricot : MonoBehaviour
{
    [SerializeField] private PlayerStatsRewindedApricot _playerStats;
    [SerializeField] private UIManagerRewindedApricot _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _playerStats.RestarVida(20);
            _uiManager.RestarFillAmount(0.2f);
        }


    }
}
