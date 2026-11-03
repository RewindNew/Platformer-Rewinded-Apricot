using UnityEngine;

public class LastChest : MonoBehaviour
{
   [SerializeField] private PlayerStatsRewindedApricot _playerStats;
    [SerializeField] private GameObject _lastDoor;

    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (_playerStats._keysCollected == 4)
        {
            _lastDoor.SetActive(false);
        }

    }
}
