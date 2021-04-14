using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppDirector : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("Menu");
    }
}
