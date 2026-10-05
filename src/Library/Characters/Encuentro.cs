public class Game
{
    private List<Heroe> heroes = new List<Heroe>();
    private List<Malo> malos = new List<Malo>();

    public void AddMalo(Malo malo)
    {
        malos.Add(malo);
    }

    public void AddBueno(Heroe heroe)
    {
        heroes.Add(heroe);
    }

    public void AtacanMalos()
    {
        for (int i = 0; i < malos.Count; i++)
        {
            if (heroes.Count > 0)
            {
                int indiceHeroe = i;

                while (indiceHeroe >= heroes.Count)
                {
                    indiceHeroe = indiceHeroe - heroes.Count;
                }

                Heroe heroe = heroes[indiceHeroe];

                heroe.RecibirDanio(malos[i].ObtenerAtaque());
            }
        }
    }

    public void AtacanBuenos()
    {
        for (int i = 0; i < heroes.Count; i++)
        {
            if (heroes[i].Vida > 0)
            {
                for (int j = 0; j < malos.Count; j++)
                {
                    if (malos[j].Vida > 0)
                    {
                        malos[j].RecibirDanio(heroes[i].ObtenerAtaque());
                    }
                }
            }
        }
    }
}