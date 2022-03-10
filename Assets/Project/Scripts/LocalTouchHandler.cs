using System;
using UnityEngine;
using TMPro;

public class LocalTouchHandler : MonoBehaviour
{
   [SerializeField] private MainMenu _gameHelper;
   [SerializeField] private AudioSource bloopSound;
  
   private void OnMouseDown()
   {
      _gameHelper._score++;
      _gameHelper._gameScoreText.text = _gameHelper._score.ToString();
      _gameHelper._pauseScoreText.text = "Текущий счёт: " + _gameHelper._gameScoreText.text;
      if (_gameHelper._bestScore < _gameHelper._score)
      {
         _gameHelper._bestScore = _gameHelper._score;
         _gameHelper._bestScoreText.text = "Рекорд: " + _gameHelper._bestScore.ToString();
      }
      bloopSound.Play();
      Debug.Log("Clicked!!!");
      Destroy(gameObject);
   }
}
