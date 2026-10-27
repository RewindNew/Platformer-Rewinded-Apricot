using UnityEngine;

public class InstantDeathRA : MonoBehaviour
{
    [SerializeField] private PlayerStatsRewindedApricot _playerStats;
    [SerializeField] private UIManagerRewindedApricot _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _playerStats.RestarVida(1000);
            _uiManager.RestarFillAmount(1f);
        }


    }
}
