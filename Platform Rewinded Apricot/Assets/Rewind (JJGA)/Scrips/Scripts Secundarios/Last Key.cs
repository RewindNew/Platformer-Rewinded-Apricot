using UnityEngine;

public class LastKey : MonoBehaviour
{
    [SerializeField] private GameObject _finalKey;
    [SerializeField] private UIManagerRewindedApricot _KeySlots;
    [SerializeField] private PlayerStatsRewindedApricot _Playerstats;
    [SerializeField] private UIManagerRewindedApricot _uiManager;

    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            _finalKey.SetActive(false);
            _KeySlots.ActivarSprite();
            _Playerstats.llaveFinal(1);


        }
    }
}
