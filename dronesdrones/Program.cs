using System;

class Program
{
    static void Main()
    {
        ReconDrone forpost = new ReconDrone(
            "Форпост-Р", "УЗГА",
            200, 250, 18, 500,
            60, 6000
        );

        AttackDrone attackDrone = new AttackDrone(
            "Форпост-РУ", "УЗГА",
            200, 250, 18, 500,
            100, "укрепления"
        );

        TransportDrone koshchey = new TransportDrone(
            "Кощей", "Авирон",
            80, 250, 6, 500,
            320, "медицинский"
        );

        LoiteringMunition lancet = new LoiteringMunition(
            "Ланцет-3", "ZALA",
            110, 100, 1, 12,
            5, "бронетехника",
            40, "оптико-электронное"
        );

        AttackReconDrone orion = new AttackReconDrone(
            "Орион", "Кронштадт",
            200, 250, 30, 1150,
            60, 7000,
            "крылатая ракета", 4
        );

        Drone[] drones = new Drone[]
        {
            forpost,
            attackDrone,
            koshchey,
            lancet,
            orion
        };

        Console.WriteLine("=== Унаследованный метод GetInfo() для всех дронов ===");
        foreach (Drone drone in drones)
        {
            Console.WriteLine(drone.GetInfo());
        }

        Console.WriteLine("\n=== Собственные методы производных классов ===");
        forpost.PerformReconnaissance();
        attackDrone.PerformStrike();
        koshchey.DeliverCargo();
        lancet.LoiterAndStrike();
        orion.PerformReconAndStrike();
    }
}
