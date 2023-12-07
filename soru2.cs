//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

Console.WriteLine("Lütfen Pozitif iki sayı giriniz. ");

Console.Write(" 1. sayıyı giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(" 2. sayıyı giriniz: ");
int m = Convert.ToInt32(Console.ReadLine());

int [] sayilar = new int[n];
Console.WriteLine($"Lütfen Pozitif {n} sayı giriniz. ");

for (int i = 0; i < sayilar.Length; i++)
{
    System.Console.WriteLine($"{i+1} . sayıyı giriniz: ");
    sayilar [i] = int.Parse(Console.ReadLine());
}
    
for (int j = 0; j < sayilar.Length; j++)
{
    
if (sayilar[j]%m==0 || sayilar[j]/m==m)
  {
             System.Console.WriteLine(sayilar[j]);
  }

}

