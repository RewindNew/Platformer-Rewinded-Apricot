using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;


public class GameManagerRewindedApricot : MonoBehaviour
{
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
