using UnityEngine;
using System.Collections.Generic
using MoreMountains.Tools;
using Unity.VisualScripting;

public class GestorLogros : MonoBehaviour
{
    [SerializeField]
    private MMAchievementList lista;

    [SerializeField]
    private List<GameObject> logros;

    void Start()
    {
        OcultarLogros();
    }

    public void Update()
    {
        ActualizarEstadoLogros();
    }
    public void OcultarLogros()
    {
        foreach (GameObject logro in logros)
        {
            logro.SetActive(false);
        }

    }
    public void ActualizarEstadoLogros()
    {
        int indice = 0;
        foreach (MMAchievement achievement in MMAchievementManager.AchievementsList)
        {
            if (indice<logros.Count)
            {
                logros[indice++].SetActive(achievement.UnlockedStatus);
            }
        }
    }
}
