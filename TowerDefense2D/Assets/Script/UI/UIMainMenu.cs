using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
    public UILevelSelect levelSelect;

    public void LevelSelectOnClicked()
    {
        levelSelect.Show();
    }
}
