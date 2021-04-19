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
        [SerializeField]
        BaseScreen settingsScreen;
        [SerializeField]
        BaseScreen resultScreen;
        public override void Show()
        {
            base.Show();

            GameInfo.Instance.Scores = 10;
        }

        public void OnSettingPressed()
        {
            NextScreen(settingsScreen);
        }

        public void OnEndGamePressed()
        {
            NextScreen(resultScreen);
        }
    }
}
