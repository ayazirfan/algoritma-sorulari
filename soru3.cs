// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

System.Console.Write("Lütfen Pozitif bir sayı giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Lütfen {n} tane kelime giriniz");
string [] kelimeler = new string[n];

for (int i = 0; i < kelimeler.Length; i++)
{
    System.Console.Write($"Lütfen {i+1} . kelimeyi giriniz: ");   
    kelimeler[i] = Console.ReadLine(); 
}
Array.Sort(kelimeler);
foreach (var kelime in kelimeler)
{
    System.Console.WriteLine(kelime);
}
