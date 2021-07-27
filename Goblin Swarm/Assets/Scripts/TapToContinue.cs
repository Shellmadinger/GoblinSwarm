using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapToContinue : MonoBehaviour
{
    public string sceneToLoad;
    bool loadLock = false;
    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began && !loadLock)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }

    void LoadScene()
    {
        if (sceneToLoad == null)
            return;

        loadLock = true;
        SceneManager.LoadScene(sceneToLoad);
    }

}
