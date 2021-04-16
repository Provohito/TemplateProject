using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.Core
{
    public abstract class BaseScreen : MonoBehaviour
    {
        public virtual void Show()
        {
            Debug.Log(name + ": Show");
            gameObject.SetActive(true);
        }

        public virtual void Hide()
        {
            Debug.Log(name + ": Hide");
            gameObject.SetActive(false);
        }
    }
}
