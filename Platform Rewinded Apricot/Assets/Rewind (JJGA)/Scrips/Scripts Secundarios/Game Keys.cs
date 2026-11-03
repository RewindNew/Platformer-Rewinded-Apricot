using UnityEngine;
using UnityEngine.UI;

public class GameKeys : MonoBehaviour
{
    [SerializeField] private GameObject _Keys;
    [SerializeField] private PlayerStatsRewindedApricot _Playerstats;
    [SerializeField] private UIManagerRewindedApricot _uiManager;
  
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            _Keys.SetActive(false);
            _Playerstats.CollectKeys(1);
            _uiManager.SumarBarraLLaves(0.25f);


        }
    }

}
