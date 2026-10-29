using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private PlayerStatsRewindedApricot _playerStats;
    [SerializeField] private UIManagerRewindedApricot _uiManager;
    [SerializeField] private GameObject _Shield;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        _playerStats.ShieldOn(1);
        _Shield.SetActive(false);
    }
}
