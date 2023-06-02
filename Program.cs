using System;

class Ticket
{
    protected int cost;

    public Ticket(int cost)
    {
        this.cost = cost;
    }

    public int Cost
    {
        get { return cost; }
    }
}

class DayTicket : Ticket
{
    private int count;

    public DayTicket(int cost, int count) : base(cost)
    {
        this.count = count;
    }

    public int Count
    {
        get { return count; }
    }

    public int DayRevenue
    {
        get { return cost * count; }
    }
}

class NightTicket : Ticket
{
    private int count;

    public NightTicket(int cost, int count) : base(cost)
    {
        this.count = count;
    }

    public int Count
    {
        get { return count; }
    }

    public int NightRevenue
    {
        get { return cost * count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int dayCost = 100; // стоимость дневных билетов
        int nightCost = 150; // стоимость ночных билетов
        int dayCount = 80; // количество дневных билетов
        int nightCount = 50; // количество ночных билетов

        DayTicket dayTicket = new DayTicket(dayCost, dayCount);
        NightTicket nightTicket = new NightTicket(nightCost, nightCount);

        int dayRevenue = dayTicket.DayRevenue;
        int nightRevenue = nightTicket.NightRevenue;
        int totalRevenue = dayRevenue + nightRevenue;

        Console.WriteLine("Предполагаемая выручка за день:");
        Console.WriteLine("Дневные билеты: {0} руб.", dayRevenue);
        Console.WriteLine("Ночные билеты: {0} руб.", nightRevenue);
        Console.WriteLine("Всего: {0} руб.", totalRevenue);
    }
}
