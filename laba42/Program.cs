using System;
using System.Collections.Generic;

// Базовий клас для Комп'ютера
class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OS { get; set; }

    public Computer(string ipAddress, int power, string os)
    {
        IPAddress = ipAddress;
        Power = power;
        OS = os;
    }
}

// Клас Сервер, спадкоємець від Computer
class Server : Computer
{
    public Server(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
        // Додаткові властивості або методи для сервера
    }
}

// Клас Робоча станція, спадкоємець від Computer
class Workstation : Computer
{
    public Workstation(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
        // Додаткові властивості або методи для робочої станції
    }
}

// Клас Маршрутизатор, спадкоємець від Computer
class Router : Computer
{
    public Router(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
        // Додаткові властивості або методи для маршрутизатора
    }
}

// Інтерфейс для з'єднання та передачі даних
interface IConnectable
{
    void Connect(Computer target);
    void Disconnect(Computer target);
    void TransmitData(Computer target, string data);
}

// Клас Мережа для моделювання взаємодії
class Network
{
    private List<Computer> computers;

    public Network()
    {
        computers = new List<Computer>();
    }

    public void AddComputer(Computer computer)
    {
        computers.Add(computer);
    }

    public void RemoveComputer(Computer computer)
    {
        computers.Remove(computer);
    }

    public void Connect(Computer source, Computer target)
    {
        Console.WriteLine($"Connected {source.IPAddress} to {target.IPAddress}");
        // Реалізуйте код для з'єднання source та target
    }

    public void Disconnect(Computer source, Computer target)
    {
        Console.WriteLine($"Disconnected {source.IPAddress} from {target.IPAddress}");
        // Реалізуйте код для відключення source від target
    }

    public void TransmitData(Computer source, Computer target, string data)
    {
        Console.WriteLine($"Transmitting data from {source.IPAddress} to {target.IPAddress}");
        // Реалізуйте код для передачі даних від source до target
    }
}

class Program
{
    static void Main(string[] args)
    {
        Network network = new Network();

        Server server = new Server("192.168.1.1", 1000, "Windows Server");
        Workstation workstation = new Workstation("192.168.1.2", 500, "Windows 10");
        Router router = new Router("192.168.1.3", 200, "Custom Router OS");

        network.AddComputer(server);
        network.AddComputer(workstation);
        network.AddComputer(router);

        // Реалізуйте імітацію з'єднання, передачі даних та відключення на мережі
    }
}
