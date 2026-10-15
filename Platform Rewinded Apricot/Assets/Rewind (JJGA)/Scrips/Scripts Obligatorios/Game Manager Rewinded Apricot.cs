using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerRewindedApricot : MonoBehaviour
{

    [SerializeField] private PlayerStatsRewindedApricot _playerStats;

    private void Start()
    {
        ReanudarElJuego();
    }

    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }

    public void PausarElJuego()
    {
        Time.timeScale = 0;
    }

    public void ReanudarElJuego()
    {
        Time.timeScale = 1;
    }
}
