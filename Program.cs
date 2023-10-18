using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia 8", "1234567890", 64);

nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("987654321", "iPhone X", "0987654321", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


