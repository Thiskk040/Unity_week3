using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
}
