using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Template.Base;
using Template.Core;

namespace Template
{
    public class MenuScreen : BaseScreen
    {
        [SerializeField]
        TextMeshProUGUI scoresText;

       

        public override void Show()
        {
            base.Show();

            scoresText.text = GameInfo.Instance.Scores.ToString();
        }



        public void OnGamePressed()
        {
            SceneManager.LoadScene("Game");
        }
    }
}
