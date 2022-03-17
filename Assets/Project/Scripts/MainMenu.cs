using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public int _bestScore;
    public int _score = 0;
    [SerializeField] private  TextMeshProUGUI _gameScoreText;
    [SerializeField] private GameObject PanelActive;
    [SerializeField] private GameObject PanelPassive;
    private void Start()
    {
        _score = 0;
        _gameScoreText.text = _score.ToString();
    }

    private void Update()
    {
        if (Time.time > 60.0)
        {
            PanelActive.SetActive(true);
            PanelPassive.SetActive(false);
        }
    }

}
