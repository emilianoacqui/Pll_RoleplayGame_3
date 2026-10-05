namespace Ucu.Poo.RoleplayGame;
public abstract class Character : ICharacter
{
    private int health;
    private List<IItem> items = new List<IItem>();

    public string Name { get; set; }

    protected Character(string name)
    {
        this.Name = name;
        this.health = 100;
    }

    public int Health
    {
        get { return this.health; }
    }

    public int AttackValue
    {
        get
        {
            int total = 0;
            foreach (IItem item in this.items)
            {
                if (item is IAttackItem attackItem)
                {
                    total += attackItem.AttackValue;
                }
            }
            return total;
        }
    }

    public int DefenseValue
    {
        get
        {
            int total = 0;
            foreach (IItem item in this.items)
            {
                if (item is IDefenseItem defenseItem)
                {
                    total += defenseItem.DefenseValue;
                }
            }
            return total;
        }
    }

    public void AddItem(IItem item)
    {
        this.items.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        this.items.Remove(item);
    }

    public void Cure()
    {
        this.health = 100;
    }

    public void ReceiveAttack(int power)
    {
        int damage = power - this.DefenseValue;
        if (damage > 0)
        {
            this.health -= damage;
            if (this.health < 0)
            {
                this.health = 0;
            }
        }
    }
}


