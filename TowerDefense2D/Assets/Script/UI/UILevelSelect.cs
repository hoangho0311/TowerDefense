using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelSelect : MonoBehaviour
{
    public UILevelButton levelButtonPrefab;
    public int LevelCount = 2;
    public Transform levelButtonHolder;
    public Animator animator;

    private void Start()
    {
        Init();
    }

    void Init()
    {
        for(int i=0; i< LevelCount; i++)
        {
            UILevelButton levelButton = Instantiate(levelButtonPrefab, levelButtonHolder);
            levelButton.SetLevel(i + 1);
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
    public void CloseOnClick()
    {
        animator.SetTrigger("close");
    }
}
