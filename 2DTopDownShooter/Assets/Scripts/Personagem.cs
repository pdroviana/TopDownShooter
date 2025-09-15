using UnityEngine;

public class Personagem : MonoBehaviour
{

    private int vida;
    private int energia;
    private int velocidade;

    public void setVida(int vida)
    {
        this.vida = vida;
    }

    public int getVida()
    {
        return vida;
    }
    
    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public int getEnergia()
    {
        return energia;
    }
    
    public void setVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    public int getVelocidade()
    {
        return velocidade;
    }
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
