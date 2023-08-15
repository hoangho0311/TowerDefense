using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGamePlay : MonoBehaviour
{
    public void MenuOnClicked()
    {
        SceneManager.LoadScene("Menu");
    }
}
