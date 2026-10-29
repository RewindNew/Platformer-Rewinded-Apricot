using UnityEngine;

public class HealTrapRewindedApricot : MonoBehaviour
{
    [SerializeField] private PlayerStatsRewindedApricot _playerStats;
    [SerializeField] private UIManagerRewindedApricot _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        _playerStats.SumarVida(10);
        _uiManager.SumarFillAmount(0.1f);
        Destroy(this.gameObject);
    }
}


    

   

