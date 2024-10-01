using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inputdetector : MonoBehaviour
{
    public string nextScene;
    void Update()
    {
        if(Input.anyKey) SceneManager.LoadScene(nextScene);
    }
}
