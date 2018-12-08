using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    [SerializeField] int TimeToWait = 4;

    private int currentSceneIndex = 0;

	// Use this for initialization
	void Start () {

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == Constants.SCENE_SPLASH_SCREEN)
        {
            StartCoroutine(LoadStartScene());
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(TimeToWait);

        SceneManager.LoadScene(Constants.SCENE_START_SCREEN);
    }
}
