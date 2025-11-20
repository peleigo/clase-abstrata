using UnityEngine;

public abstract class Arma
{
    private string nome;
    private int dano;

    public Arma(string nome, int dano)
    {
        this.nome = nome;
        this.dano = dano;
    }

    public int GetDano()
    {
        return dano;
    }

    public string GetNome()
    {
        return nome;
    }

    public abstract void Usar();
}
