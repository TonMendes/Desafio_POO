using Celular_POO.Entities;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "34569087", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");