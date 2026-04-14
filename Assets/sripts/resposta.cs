using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement; 
public class responder : MonoBehaviour {

    public int idTema;

    public TMP_Text pergunta;
    public TMP_Text respostaA;
    public TMP_Text respostaB;
    public TMP_Text respostaC;
    
    public TMP_Text infoRespostas;

    public string[] perguntas;      
    public string[] alternativaA;   
    public string[] alternativaB;   
    public string[] alternativaC;   

    public string[] corretas;       
    private int idPergunta;

    private float acertos;
    private float questoes;
    private float media;

}