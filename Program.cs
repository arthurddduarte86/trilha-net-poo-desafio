using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia1 = new Nokia(numero: "1234", modelo: "Nokia5125", imei: "11111111", memoria: 4096);
nokia1.Ligar();
nokia1.InstalarAplicativo("Instagram");

Smartphone iphone1 = new Iphone(numero: "13579", modelo: "Iphone14", imei: "2222222", memoria: 1024);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Youtube");


