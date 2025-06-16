using UnityEngine;

public class Inimigo : Personagem

 
{
    public enum ArmaDoInimigo
    {
      Magma, Fogo, Gosma
    }


    public enum ArmaduraDoInimigo
    {
      Magma
    }
  
    [SerializeField]
    private ArmaduraDoInimigo armadura;
    [SerializeField]
    private ArmaDoInimigo arma;

    
    public void AtribuirArmadura(ArmaduraDoInimigo armadura)
    {
      this.armadura = armadura;
    }

    public ArmaduraDoInimigo Armadura()
    {
      return this.armadura;
    }

    public void AtribuirArma(ArmaDoInimigo arma)
    {
      this.arma = arma;
    }

    public ArmaDoInimigo Arma()
    {
      return this.arma;
    }

    public int DanoDoInimigo()
    {
      int dano = 0;

      switch (arma)
      {
        case ArmaDoInimigo.Magma:
          dano = Dano() + 6;
          break;
        case ArmaDoInimigo.Fogo:
          dano = Dano() + 3;
          break;
        case ArmaDoInimigo.Gosma:
          dano = Dano() + 0;
          break;
      }

      return dano;
    }
    
    
}

