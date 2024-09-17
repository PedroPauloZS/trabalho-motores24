using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI HUD, MsgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<Moeda>().Length;

        HUD.text = $"Moedas Restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        HUD.text = $"Moedas Restantes: {restantes}";
        source.PlayOneShot(clipMoeda);


        if (restantes <= 0)
        {
            MsgVitoria.text = "Parabéns!";
            source.Stop();
            source.PlayOneShot(clipVitoria);
        }
    } 


    // Update is called once per frame
    void Update()
    {

    }
}

