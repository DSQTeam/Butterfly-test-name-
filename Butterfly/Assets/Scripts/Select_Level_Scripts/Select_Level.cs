using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Select_Level : MonoBehaviour
{
    public void Level_selection()
    {
        SceneManager.LoadSceneAsync(2);

    }
    
}
