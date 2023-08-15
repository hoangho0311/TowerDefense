using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UILevelButton : MonoBehaviour
{
    public TextMeshProUGUI txtLevel;
    public int Level;
    public void SetLevel(int level)
    {
        this.Level = level;
        txtLevel.text = this.Level.ToString();
    }
    public void LevelButtonOnclicked()
    {
        SceneManager.LoadScene("Map " + this.Level);
    }
}
