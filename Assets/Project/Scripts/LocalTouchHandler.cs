using System;
using UnityEngine;
using TMPro;

public class LocalTouchHandler : MonoBehaviour
{
   [SerializeField] private Controller controller;
   [SerializeField] private AudioSource bloopSound;
   
   private void OnMouseDown()
   {
      controller.OnClick();
      bloopSound.Play();
      Destroy(gameObject);
   }
}
