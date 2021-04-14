using System.Collections;
using System.Collections.Generic;
using Template.Base;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameInfo.Instance.Scores = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMenuPressed()
    {
        SceneManager.LoadScene("Menu");
    }
}
