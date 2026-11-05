using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
   [SerializeField] public TMP_Text Textotiempo;
   [SerializeField] public float tiempo = 240f;
   [SerializeField] public GameObject panelTimeOut;

    void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            int minutos = Mathf.FloorToInt(tiempo / 60);
            int segundos = Mathf.FloorToInt(tiempo % 60);
            Textotiempo.text = minutos.ToString("00") + ":" + segundos.ToString("00");

        }
        else
        {
            tiempo = 0;
            Textotiempo.text = "00:00";
            Time.timeScale = 0f;
            panelTimeOut.SetActive(true);
        }
    }

}

