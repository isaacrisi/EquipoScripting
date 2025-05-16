using MoreMountains.Tools
using UnityEngine;

public class EnemyKillCounter : MonoBehaviour
{
    private int killCount = 0;

    void OnEnemyKilled()
    {
        killCount++;

        if (killCount >= 10)
        {
            MMAchievementManager.UnlockAchievement("10_kills");
        }
    }
}
