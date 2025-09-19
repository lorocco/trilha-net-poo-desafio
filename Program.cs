using DesafioPOO.Models;

Console.WriteLine("Instalando aplicativo no Nokia");
Smartphone nokia = new Nokia(numero: "(11)95924-0547", modelo: "NokiaJ2", imei: "18191fFFAF89", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da Cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Instalando aplicativo no Iphone");
Smartphone iphone = new Iphone(numero: "(11)95481-1812", modelo: "Iphone 15", imei: "71756fa4fagDf", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

