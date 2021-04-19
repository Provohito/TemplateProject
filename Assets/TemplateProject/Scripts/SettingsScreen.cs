using System.Collections;
using System.Collections.Generic;
using Template.Core;
using UnityEngine;

namespace Template
{
    public class SettingsScreen : BaseScreen
    {
        [SerializeField]
        BaseScreen backScreen;
        public void OnBackPressed()
        {
            NextScreen(backScreen);
        }
    }
}
