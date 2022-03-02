using System;
using UnityEngine;

public class LocalTouchHandler : MonoBehaviour
{
   private MainMenu _gameHelper;

   void Start()
   {
      _gameHelper = Canvas.FindObjectOfType<MainMenu>();
   }
   private void OnMouseDown()
   {
      _gameHelper._score++;
      Debug.Log("Clicked!!!");
      Destroy(gameObject);
   }
}
