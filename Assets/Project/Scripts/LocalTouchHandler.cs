using System;
using UnityEngine;
using TMPro;

public class LocalTouchHandler : MonoBehaviour
{
   [SerializeField] private MainMenu _gameHelper;
   [SerializeField] private AudioSource bloopSound;
   [SerializeField] private TextMeshProUGUI _pauseScoreText;
   [SerializeField] private  TextMeshProUGUI _gameScoreText;
   [SerializeField] private TextMeshProUGUI _bestScoreText;
   private void OnMouseDown()
   {
      _gameHelper._score++;
      _gameScoreText.text = _gameHelper._score.ToString();
      _pauseScoreText.text = "Текущий счёт: " + _gameScoreText.text;
      if (_gameHelper._bestScore < _gameHelper._score)
      {
         _gameHelper._bestScore = _gameHelper._score;
         _bestScoreText.text = "Рекорд: " + _gameHelper._bestScore.ToString();
      }
      bloopSound.Play();
      Debug.Log("Clicked!!!");
      Destroy(gameObject);
   }
}
