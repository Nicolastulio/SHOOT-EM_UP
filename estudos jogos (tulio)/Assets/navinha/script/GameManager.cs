using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public static GameManager Instance;

    [Header("Pontuação")]
    public int score;
    public TMP_Text ScoreText;


    [Header("GeradordeAlan")]
    public GameObject objetoAlan;
    public Transform[] geradoresAlan;
    public float taxaAlan;


    private void Awake()
    {
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GerarAlan());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AlterarScore(int valor)
    {
        score += valor;
        ScoreText.text = "Score :" + score;
   
    }

     IEnumerator GerarAlan() 
    {
        int rnd = Random.Range(0, geradoresAlan.Length);
        Instantiate(objetoAlan, geradoresAlan[rnd].position,Quaternion.identity);
        yield return new WaitForSeconds(taxaAlan);
        StartCoroutine(GerarAlan());
    }


}
