using System.Collections;
using System.Collections.Generic;
using Template.Base;
using Template.Core;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Template
{
    public class ResultsScreen : BaseScreen
    {
        [SerializeField]
        BaseScreen gameScreen;

        [SerializeField]
        TextMeshProUGUI scoresText;
        public override void Show()
        {
            base.Show();

            scoresText.text = GameInfo.Instance.Scores.ToString();
        }

        public void OnRestartPressed()
        {
            NextScreen(gameScreen);
        }

        public void OnMenuPressed()
        {
            SceneManager.LoadScene(Scenesids.Menu);
        }
    }
}
