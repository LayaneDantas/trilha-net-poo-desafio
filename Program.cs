using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "1234", modelo: "14plus", imei:"11111111", memoria:64 );
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Jogo do Tigre");


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "5678", modelo: "MotoG10Play", imei: "22222222", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Pou");
    
