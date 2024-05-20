using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back: MonoBehaviour
{
    public Button initialButton;
    public Button newButton;

    void Start()
    {
        newButton.gameObject.SetActive(false);
        initialButton.onClick.AddListener(ShowNewButton);
        newButton.onClick.AddListener(HideNewButton);
    }

    void ShowNewButton()
    {
        newButton.gameObject.SetActive(true);
    }

    void HideNewButton()
    {
        newButton.gameObject.SetActive(false);
    }
}
