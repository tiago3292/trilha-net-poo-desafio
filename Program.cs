﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone (FEITO)
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", iMEI: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "456789", modelo: "Modelo 2", iMEI: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");