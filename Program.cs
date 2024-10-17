using Celular.Models;

IPhone iph = new IPhone("123456", "X Pro", "2580",128);
Nokia nok = new Nokia("654321", "Tijolão", "1379",2);

Console.WriteLine("=> IPhone:");
iph.Ligar(); 
iph.ReceberLigacao();
iph.InstalarAplicativo("Facebook 2");

Console.WriteLine("=> Nokia:");

nok.ReceberLigacao();
nok.Ligar();
nok.InstalarAplicativo("WhatsApp 2");