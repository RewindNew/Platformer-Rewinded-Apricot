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
