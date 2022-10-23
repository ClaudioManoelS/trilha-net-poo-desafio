using DesafioPOO.Models;

Console.WriteLine("Teste Nokia:");
var nokia = new Nokia(numero: "12345678", modelo: "H95", imei: "987654321", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("Número: " + nokia.Numero);

Console.WriteLine();

Console.WriteLine("Teste Iphone:");
var iphone = new Iphone(numero: "44568134", modelo: "13 MAX PRO", imei: "11111111", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine("Número: " + iphone.Numero);

