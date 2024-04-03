using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Select_Level : MonoBehaviour
{
    public void Choose_Level()
    {
        SceneManager.LoadSceneAsync(1);

    }
    
    
}
