using System.Collections;
using System.Collections.Generic;
using Template.Base;
using Template.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Template
{
    public class GameScreen : BaseScreen
    {

        public override void Show()
        {
            base.Show();

            GameInfo.Instance.Scores = 10;
        }

        public void OnMenuPressed()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
