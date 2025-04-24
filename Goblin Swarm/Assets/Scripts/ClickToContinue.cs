
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToContinue : MonoBehaviour {

	public string scene;
	private bool loadLock = false;
	
	void Update () {
		if(Input.GetMouseButtonDown(0) && !loadLock)
		{
			LoadScene();
		}
	}

	void LoadScene()
	{
		if (scene == null)
			return;

		loadLock = true; 
        SceneManager.LoadScene(scene);
	}
}
