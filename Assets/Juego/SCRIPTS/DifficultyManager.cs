using UnityEngine
using System;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public enum Difficulty { Easy, Medium, Hard }

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager Instance { get; private set; }

    public Difficulty CurrentDifficulty { get; private set; } = Difficulty.Easy;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetDifficulty(Difficulty difficulty)
    {
        CurrentDifficulty = difficulty;
        MMSceneLoadingManager.LoadScene("NIVEL1");
    }

    public void SetEasy()
    {
        SetDifficulty(Difficulty.Easy);
    }

    public void SetMedium()
    {
        SetDifficulty(Difficulty.Medium);
    }

    public void SetHard()
    {
        SetDifficulty(Difficulty.Hard);
    }
}
