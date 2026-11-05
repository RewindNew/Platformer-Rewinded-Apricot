using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private PlayerStatsRewindedApricot _playerStats;
    [SerializeField] private UIManagerRewindedApricot _uiManager;

    private void OnCollisionEnter2D(Collision2D colision)
    {
        _uiManager.SumarPointsFillAmount(0.25f);
        _playerStats.SumarPuntos(25);

    }

}
