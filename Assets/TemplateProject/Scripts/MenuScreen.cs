using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScreen : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoresText;

    void Start()
    {
        scoresText.text = GameInfo.Instance.Scores.ToString();
    }

    void Update()
    {
        
    }

    public void OnGamePressed()
    {
        SceneManager.LoadScene("Game");
    }
}
