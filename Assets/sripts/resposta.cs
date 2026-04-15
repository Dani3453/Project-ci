using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicaPergunta : MonoBehaviour
{
    public string respostaCorreta;
    public string nomeDaProximaCena;
    public bool ehAPrimeiraPergunta; // Marque isso no Inspector apenas na Pergunta 1

    void Start()
    {
        // Se este script estiver na primeira pergunta do quiz, ele reseta os pontos
        if (ehAPrimeiraPergunta)
        {
            PlayerPrefs.SetInt("AcertosAcumulados", 0);
            PlayerPrefs.Save();
            Debug.Log("O quiz começou! Pontuação resetada para 0.");
        }
    }

    public void Responder(string alternativaClicada)
    {
        int acertosAtuais = PlayerPrefs.GetInt("AcertosAcumulados", 0);

        if (alternativaClicada == respostaCorreta)
        {
            acertosAtuais++;
            PlayerPrefs.SetInt("AcertosAcumulados", acertosAtuais);
            Debug.Log("Acertou! Total agora: " + acertosAtuais);
        }

        if (nomeDaProximaCena == "resultados")
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        SceneManager.LoadScene(nomeDaProximaCena);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "resultados")
        {
            int acertos = PlayerPrefs.GetInt("AcertosAcumulados", 0);

            GameObject textoObj = GameObject.Find("Text (TMP)");
            GameObject textoObj1 = GameObject.Find("Text (TMP) (1)");
            
            if (textoObj != null)
            {
                textoObj.GetComponent<TextMeshProUGUI>().text = "Acertou " + acertos + " de 14 perguntas!";
            }
             
            if (textoObj1 != null)
            {
                textoObj1.GetComponent<TextMeshProUGUI>().text = "" + acertos;
            }

            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }
}