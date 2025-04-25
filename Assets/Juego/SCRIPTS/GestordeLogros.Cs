using UnityEngine;
using System.Collections.Generic;

public class GestorLogros : MonoBehaviour
{
    public static GestorLogros instancia;
    public List<Logro> logros;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void DesbloquearLogro(string nombre)
    {
        Logro logro = logros.Find(l => l.nombre == nombre);
        if (logro != null && !logro.desbloqueado)
        {
            logro.desbloqueado = true;
            PlayerPrefs.SetInt(nombre, 1);
            Debug.Log("Logro desbloqueado: " + nombre);
            // Aquí podrías activar un popup si haces uno después
        }
    }

    public bool EstaDesbloqueado(string nombre)
    {
        return PlayerPrefs.GetInt(nombre, 0) == 1;
    }
}
