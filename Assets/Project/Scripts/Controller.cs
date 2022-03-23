using System;
using System.Threading;
using TMPro;
using UnityEngine;
using Timer = System.Timers.Timer;

public class Controller : MonoBehaviour
{
    [SerializeField] private MainMenu _gameHelper;
    
    [SerializeField] private TextMeshProUGUI _pauseScoreText;
    [SerializeField] private  TextMeshProUGUI _gameScoreText;
    [SerializeField] private TextMeshProUGUI _bestScoreText;
    public Timer Timer;
    [SerializeField] public TextMeshProUGUI _timer;
    private void Start()
    {
        
        
        
        //_timer = new Timer(tm, null, 0, 2000);
        
    }
    
    

    public void OnClick()
    {
        Debug.Log("Clicked!!!");
        _gameHelper._score++;
        _gameScoreText.text = _gameHelper._score.ToString();
        _pauseScoreText.text = "Текущий счёт: " + _gameScoreText.text;
        if (_gameHelper._bestScore < _gameHelper._score)
        {
            _gameHelper._bestScore = _gameHelper._score;
            _bestScoreText.text = "Рекорд: " + _gameHelper._bestScore.ToString();
        }
        
    }
    
}