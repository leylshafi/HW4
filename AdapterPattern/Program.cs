interface IFighter
{
    void Attack();
    void Defend();
    void Escape();
}

class Soldier : IFighter
{
    public void Attack()
    {
        Console.WriteLine("Soldier Attack");
    }

    public void Defend()
    {
        Console.WriteLine("Soldier Defend");
    }

    public void Escape()
    {
        Console.WriteLine("Soldier Escape");
    }
}

class Wizard
{
    public void CastDestructionSpell()
    {
        Console.WriteLine("CastDestructionSpell");
    }
    public void Shield()
    {
        Console.WriteLine("Shield");
    }
    public void Portal()
    {
        Console.WriteLine("Portal");
    }
}
class WizardAdapter : Wizard, IFighter
{
    public void Attack()
    {
        Console.WriteLine("Wizard Attack");
    }

    public void Defend()
    {
        Console.WriteLine("Wizard Defend");
    }

    public void Escape()
    {
        Console.WriteLine("Wizard Escape");
    }
}




class Program
{
    static void Main()
    {
        List<IFighter> fighters = new()
        {
            new Soldier(),
            new WizardAdapter()
        };


        foreach (var fighter in fighters)
        {
            fighter.Attack();
            fighter.Defend();
            fighter.Escape();
            Console.WriteLine("===============");
        }
           
    }
}