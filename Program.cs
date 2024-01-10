using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:\n");
Smartphone nokia = new Nokia("8298188-9670", "C20", "000000001010", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Nubank");

Console.WriteLine("\nSmatphone Iphone:\n");
Smartphone iphone = new Iphone("8199450-3223", "XR", "000000001020",64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Coffeely");

