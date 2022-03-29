using Tarea_Semana_8.Clases;

Carro CarroA;
Carro CarroB;
Carro CarroC;

string marca;
int contadorA = 0;
int contadorB = 0;
int contadorC = 0;
int velocidad;
string propietario;
Random velram = new Random();
velocidad = velram.Next(5, 200);
for (int i = 0; i < 3; i++)
{
    //A
    Console.WriteLine("Ingrese los datos del equipo A");
    Console.WriteLine("Ingrese marca");
    marca = Console.ReadLine();
    Console.WriteLine("Propietario:");
    propietario = Console.ReadLine();
    CarroA = new Carro(marca, velocidad, propietario);

    //B
    Console.WriteLine("Ahora datos del equipo B");
    Console.WriteLine("Ingrese marca");
    marca = Console.ReadLine();
    Console.WriteLine("Propietario:");
    propietario = Console.ReadLine();
    CarroB = new Carro(marca, velocidad, propietario);

    //C
    Console.WriteLine("Ahora datos del equipo C");
    Console.WriteLine("Ingrese marca");
    marca = Console.ReadLine();
    Console.WriteLine("Propietario:");
    propietario = Console.ReadLine();
    CarroC = new Carro(marca, velocidad, propietario);

    string msgCarroA, msgCarroB, msgCarroC;
    Random velRandom = new Random();




    msgCarroA = CarroA.EncenderMotor();
    msgCarroB = CarroB.EncenderMotor();
    msgCarroC = CarroC.EncenderMotor();
    Console.WriteLine($"{CarroA.Marca} {msgCarroA}");
    Console.WriteLine($"{CarroB.Marca} {msgCarroB}");
    Console.WriteLine($"{CarroC.Marca}{msgCarroC}");


    for (int ii = 0; ii < 10; ii++)
    {
        int acelera;
        acelera = velRandom.Next(1, 21);
        msgCarroA = CarroA.acelerar(acelera);
        acelera = velRandom.Next(1, 21);
        msgCarroB = CarroB.acelerar(acelera);
        acelera = velRandom.Next(1, 21);
        msgCarroC = CarroC.acelerar(acelera);
        Console.WriteLine($"{i + 1}- {CarroA.owner}:{msgCarroA}  {CarroB.owner}:{msgCarroB}{CarroC.owner}:{msgCarroC} ");

    }

    if (CarroA.GetVelocidadActual() > CarroB.GetVelocidadActual() & CarroA.GetVelocidadActual() > CarroC.GetVelocidadActual())
    {
        Console.WriteLine($"{CarroA.owner} Ganooo esta manga!!!");
        contadorA = contadorA + 1;

    }
    if (CarroB.GetVelocidadActual() > CarroA.GetVelocidadActual() & CarroB.GetVelocidadActual() > CarroC.GetVelocidadActual())
    {
        Console.WriteLine($"{CarroB.owner} Ganooo esta manga!!!");
        contadorB = contadorB + 1;
    }
    if (CarroC.GetVelocidadActual() > CarroB.GetVelocidadActual() & CarroC.GetVelocidadActual() > CarroA.GetVelocidadActual())
    {
        Console.WriteLine($"{CarroC.owner} Ganooo esta manga!!!");
        contadorC = contadorC + 1;
    }
}
if (contadorA > contadorB & contadorA > contadorC)
{
    Console.WriteLine($"El equipo A ganoo la carrera!!!");
}
if (contadorB > contadorA & contadorB > contadorC)
{
    Console.WriteLine($"El equipo B ganoo la carrera!!!");
}
if (contadorC > contadorB & contadorC > contadorA)
{
    Console.WriteLine($"El equipo C ganoo la carrera!!!");
}
if (contadorA == contadorB & contadorA == contadorC)
{
    Console.WriteLine($"La carrera es un empate!!!");
}