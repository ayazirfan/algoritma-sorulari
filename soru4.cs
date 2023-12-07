//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

System.Console.WriteLine("Lütfen bir CÜMLE yazınız:");
string n = Console.ReadLine();
string cumle= n;

Console.WriteLine("Yazdığınız cümle toplam {0} karakter içerir.", cumle.Length);

int kelimeSayisi= cumle.Trim().Split(' ').Length;

Console.Write("Yazdığınız cümle {0} kelime içerir.", kelimeSayisi.ToString());
