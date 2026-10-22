using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsRewindedApricot : MonoBehaviour
{
    [SerializeField] private int _puntosVidaActuales = 100;
    [SerializeField] private int _vidaMaxima = 100;
    [SerializeField] private Image _barra;
    [SerializeField] private GameManagerRewindedApricot _gameManager;
    public int _keysCollected = 0;

    public void RestarVida(int daño)
    {
        _puntosVidaActuales -= daño;
    }

    public void SumarVida(int heal)
    {
        _puntosVidaActuales += heal;
        if (_puntosVidaActuales > _vidaMaxima)
        {
            _puntosVidaActuales = _vidaMaxima;
        }
    }

    public void CollectKeys(int keys)
    {
        _keysCollected += keys;
    }

    private void Update()
    {
        if (_barra.fillAmount >= 0.8f)
        {
            _barra.color = Color.green;
        }

        if (_barra.fillAmount <= 0.7f && _barra.fillAmount >= 0.3f)
        {
            _barra.color = Color.yellow;
        }

        if (_barra.fillAmount <= 0.3f && _barra.fillAmount > 0.0f)
        {
            _barra.color = Color.red;
        }

        if (_barra.fillAmount <= 0.0f)
        {
            _gameManager.PausarElJuego();
        }

    }
}