using UnityEngine;

public class ResetPontuacao : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("AcertosAcumulados", 0);
        PlayerPrefs.Save(); // garante que salva imediatamente
        Debug.Log("Pontuação resetada para 0");
    }
}

