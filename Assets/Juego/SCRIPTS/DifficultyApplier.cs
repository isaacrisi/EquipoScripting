using UnityEngine;
using MoreMountains.CorgiEngine;

public class DifficultyApplier : MonoBehaviour
{
    public Health playerHealth;
    public Weapon playerWeapon;
    public float easyHealthMultiplier = 1.2f;
    public float easyDamageMultiplier = 1.2f;
    public float hardHealthMultiplier = 0.7f;
    public float hardDamageMultiplier = 0.7f;

    void Start()
    {
        if (DifficultyManager.Instance == null) return;
        switch (DifficultyManager.Instance.CurrentDifficulty)
        {
            case Difficulty.Easy:
                if (playerHealth != null)
                {
                    playerHealth.InitialHealth *= easyHealthMultiplier;
                    playerHealth.ResetHealthToMaxHealth();
                }
                if (playerWeapon != null)
                {
                    // Si es un arma cuerpo a cuerpo
                    var melee = playerWeapon as MeleeWeapon;
                    if (melee != null)
                    {
                        melee.MinDamageCaused = Mathf.RoundToInt(melee.MinDamageCaused * easyDamageMultiplier);
                        melee.MaxDamageCaused = Mathf.RoundToInt(melee.MaxDamageCaused * easyDamageMultiplier);
                    }
                    // Si es un arma de proyectil
                    var projectile = playerWeapon.GetType().Name == "ProjectileWeapon" ? playerWeapon : null;
                    if (projectile != null)
                    {
                        var minField = projectile.GetType().GetField("MinDamageCaused");
                        var maxField = projectile.GetType().GetField("MaxDamageCaused");
                        if (minField != null && maxField != null)
                        {
                            int min = (int)minField.GetValue(projectile);
                            int max = (int)maxField.GetValue(projectile);
                            minField.SetValue(projectile, Mathf.RoundToInt(min * easyDamageMultiplier));
                            maxField.SetValue(projectile, Mathf.RoundToInt(max * easyDamageMultiplier));
                        }
                    }
                }
                break;
            case Difficulty.Hard:
                if (playerHealth != null)
                {
                    playerHealth.InitialHealth *= hardHealthMultiplier;
                    playerHealth.ResetHealthToMaxHealth();
                }
                if (playerWeapon != null)
                {
                    var melee = playerWeapon as MeleeWeapon;
                    if (melee != null)
                    {
                        melee.MinDamageCaused = Mathf.RoundToInt(melee.MinDamageCaused * hardDamageMultiplier);
                        melee.MaxDamageCaused = Mathf.RoundToInt(melee.MaxDamageCaused * hardDamageMultiplier);
                    }
                    var projectile = playerWeapon.GetType().Name == "ProjectileWeapon" ? playerWeapon : null;
                    if (projectile != null)
                    {
                        var minField = projectile.GetType().GetField("MinDamageCaused");
                        var maxField = projectile.GetType().GetField("MaxDamageCaused");
                        if (minField != null && maxField != null)
                        {
                            int min = (int)minField.GetValue(projectile);
                            int max = (int)maxField.GetValue(projectile);
                            minField.SetValue(projectile, Mathf.RoundToInt(min * hardDamageMultiplier));
                            maxField.SetValue(projectile, Mathf.RoundToInt(max * hardDamageMultiplier));
                        }
                    }
                }
                break;
            // Puedes agregar más casos para Medium si lo deseas
        }
    }
}
