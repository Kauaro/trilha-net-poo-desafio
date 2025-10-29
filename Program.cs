using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1232", modelo: "v1", imei: "14141414", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "2532", modelo: "v1", imei: "14141414", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");