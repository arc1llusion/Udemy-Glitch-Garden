using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master valume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MIN_VOLUME = 0;
    const float MAX_VOLUME = 1;

    const float MIN_DIFFICULTY = 0;
    const float MAX_DIFFICULTY = 2;

    const float defaultVolume = 0.8f;
    const float defaultDifficulty = 0;

    public static void SetMasterVolume(float volume)
    {
        volume = Mathf.Clamp(volume, MIN_VOLUME, MAX_VOLUME);
        PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY, defaultVolume);
    }

    public static void SetDifficulty(float difficulty)
    {
        difficulty = Mathf.Clamp(difficulty, MIN_DIFFICULTY, MAX_DIFFICULTY);
        PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY, defaultDifficulty);
    }
}
