using System;

class Player
{
    public int Vida { get; set; }
    public string Posicion { get; set; }
    public float Velocidad { get; set; }
    public bool DobleSaltoDisponible { get; set; }
    public float JetPackTiempoRestante { get; set; }
    
    public void Mover() {}
    public void Saltar() {}
    public void DobleSaltar() {}
    public void UsarJetPack() {}
    public void EmpujarObjeto() {}
    public void RecibirDano() {}
    public void RecogerPowerUp() {}
}

class Enemy
{
    public string Posicion { get; set; }
    public int Dano { get; set; }
    
    public void Mover() {}
    public void HacerDano() {}
}

class Platform
{
    public string Posicion { get; set; }
    public string Tipo { get; set; }
    
    public void Interactuar() {}
}

class MovingPlatform : Platform
{
    public string Direccion { get; set; }
    public float Velocidad { get; set; }
}

class FallingPlatform : Platform
{
    public float TiempoReaparicion { get; set; }
}

class Item
{
    public string Posicion { get; set; }
}

class PowerUp : Item
{
    public float Duracion { get; set; }
}

class Coin : Item
{
    public int Valor { get; set; }
}

class Level
{
    public int NumeroNivel { get; set; }
    public List<string> Obstaculos { get; set; }
    public List<Enemy> Enemigos { get; set; }
    public List<string> PuntosDeReaparicion { get; set; }
    
    public void Iniciar() {}
    public void SiguienteNivel() {}
}

class GameManager
{
    public void DetectarGameOver(Player jugador)
    {
        if (jugador.Vida <= 0)
        {
            ReaparecerJugador(jugador);
        }
    }
    
    public void ReaparecerJugador(Player jugador)
    {
        jugador.Posicion = "Nivel 1";
        jugador.Vida = 100; // Asignando vida inicial
    }
    
}
