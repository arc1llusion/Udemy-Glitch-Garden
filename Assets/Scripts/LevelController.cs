using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerable<AttackerSpawner> attackerSpawners;
    GameTimer gameTimer;

    [SerializeField] GameObject winLabel;

    [SerializeField] float WinTimeToWait = 4;

    bool winTriggered = false;
    void Start()
    {
        winLabel.SetActive(false);

        attackerSpawners = FindObjectsOfType<AttackerSpawner>();
        gameTimer = FindObjectOfType<GameTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        bool areEnemiesDead = attackerSpawners.All(a => a.transform.childCount == 0);
        bool isTimerDone = gameTimer.IsLevelFinished;

        if (isTimerDone)
        {
            foreach(var spawner in attackerSpawners)
            {
                spawner.StopSpawning();
            }
        }

        if(!winTriggered && areEnemiesDead && gameTimer.IsLevelFinished)
        {
            winTriggered = true;
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(WinTimeToWait);

        GetComponent<LevelLoader>().LoadNextScene();
    }
}
