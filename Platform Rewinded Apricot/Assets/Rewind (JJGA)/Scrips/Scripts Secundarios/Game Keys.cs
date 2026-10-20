using UnityEngine;
using UnityEngine.UI;

public class GameKeys : MonoBehaviour
{
    [SerializeField] private GameObject _Keys;
    [SerializeField] private UIManagerRewindedApricot _KeySlots;
    [SerializeField] private PlayerStatsRewindedApricot _Playerstats;

    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _Keys.SetActive(false);
            _KeySlots.ActivarSprite();
            _Playerstats.CollectKeys(1);
        }
   
    }
}
