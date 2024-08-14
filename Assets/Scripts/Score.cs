using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int Playerscore;
    private Text scoreText;
    private AudioSource audio;
    // Start is called before the first frame update

    private void Awake()
    {
        scoreText = GetComponent<Text>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {

        Playerscore = Playerscore + scoreToAdd;
        scoreText.text = "Score"+":"+ Playerscore.ToString();
        audio.Play();


    }
}
