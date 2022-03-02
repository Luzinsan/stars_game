using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public int _bestScore;
    public int _score = 0;
    [SerializeField] public  TextMeshProUGUI _gameScoreText;
    [SerializeField] private TextMeshProUGUI _bestScoreText;
    [SerializeField] private TextMeshProUGUI _pauseScoreText;

    void Start()
    {
        _score = 0;
        _gameScoreText.text = _score.ToString();
    }
    void Update()
    {
        _gameScoreText.text = _score.ToString();
        _pauseScoreText.text = "Текущий счёт: " + _gameScoreText.text;
        if (_bestScore < _score)
        {
            _bestScore = _score;
            _bestScoreText.text = "Рекорд: " + _bestScore.ToString();
        }
        
    }
    
    
}
