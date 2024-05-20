using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podskazka : MonoBehaviour
{
    bool pressPodskazka;
    public RectTransform slider;
    Vector2 v;
    bool pressExit;

    private void Start()
    {
        v=slider.anchorMax;
    }
    private void Update()
    {
        if(pressPodskazka)
        {
            v.x += 0.01f;
            slider.anchorMax=v;
            if (slider.anchorMax.x>=0.2f)
            {
                pressPodskazka = false;
            }
        }

        if (pressExit)
        {
            v.x -= 0.01f;
            slider.anchorMax = v;
            if (slider.anchorMax.x <= 0)
            {
                pressExit = false;
            }
        }
    }

    public void Podskazka()
    {
        pressPodskazka = true;
    }
    public void Exit()
    {
        pressExit = true;
    }
}
