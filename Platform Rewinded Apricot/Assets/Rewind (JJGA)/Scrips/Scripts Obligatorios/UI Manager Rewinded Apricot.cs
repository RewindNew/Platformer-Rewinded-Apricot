using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManagerRewindedApricot : MonoBehaviour
{
    [SerializeField] private Image _barra;
    [SerializeField] private GameManagerRewindedApricot _gameManager;
    [SerializeField] private GameObject _panelDefeat;
    [SerializeField] private GameObject _panelVictory;
    [SerializeField] private GameObject _KeySlot;
    [SerializeField] private PlayerStatsRewindedApricot _playerStats;
    [SerializeField] private Image _PointsBar;
    [SerializeField] private Image _keysBar;

    public void SumarBarraLLaves(float amount)
    {
        _keysBar.fillAmount += amount;
    }

    public void SumarPointsFillAmount(float amount)
    {
        _PointsBar.fillAmount += amount;
    }

    public void SumarFillAmount(float amount)
    {
        _barra.fillAmount += amount;
    }

    public void RestarFillAmount(float amount)
    {
        _barra.fillAmount -= amount;
    }

    private void Update()
    {
        if (_barra.fillAmount <= 0.0f)
        {
            _panelDefeat.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            _gameManager.PausarElJuego();
            _panelVictory.SetActive(true);
        }

    }


    public void ActivarSprite()
    {
        _KeySlot.SetActive(true);
    }



}
