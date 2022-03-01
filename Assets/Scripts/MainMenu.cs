using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int _bestScore;
    public int _score = 0;
    [SerializeField] private Text _scoreText;

    
    void Update()
    {
        _scoreText.text = _score.ToString();
        if (Input.GetKey("escape"))
        {
            if (_bestScore < _score)
                _bestScore = _score;
            
        }

    }

   
}
