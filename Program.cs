using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "11912345678", modelo: "Lumia 1020", imei: "101010101010101", memoria: 2);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Netflix");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");

Smartphone iphone = new Iphone(numero: "31912345678", modelo: "14 Plus", imei: "110011001100110", memoria: 6);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");