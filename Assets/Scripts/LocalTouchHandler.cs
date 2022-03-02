using System;
using UnityEngine;

public class LocalTouchHandler : MonoBehaviour
{
   private MainMenu _gameHelper;
   public AudioSource bloopSound;
   void Start()
   {
      _gameHelper = Canvas.FindObjectOfType<MainMenu>();
   }
   private void OnMouseDown()
   {
      _gameHelper._score++;
      bloopSound.Play();
      Debug.Log("Clicked!!!");
      Destroy(gameObject);
   }
}
