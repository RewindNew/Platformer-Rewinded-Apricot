using Unity.VisualScripting;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    [SerializeField] private PlayerStatsRewindedApricot _playerStats;
    [SerializeField] private GameObject _door;


    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (_playerStats._keysCollected == 4)
        {
            _door.SetActive(false);
        }

    }
}
