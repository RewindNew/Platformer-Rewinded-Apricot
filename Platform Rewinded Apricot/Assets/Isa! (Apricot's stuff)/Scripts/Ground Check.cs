using UnityEngine;

public class GroundCheckRwindedApricot : MonoBehaviour
{
    public bool estaEnSuelo;

    private void OnTriggerExit2D(Collider2D colision)
    {
        estaEnSuelo = false;
        Debug.Log("Estoy saltando");
    }

    private void OnTriggerStay2D(Collider2D colision)
    {
        estaEnSuelo = true;
        Debug.Log("Toco el suelo");
    }
}
