// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


// Console.WriteLine("Lütfen Bir Sayı Giriniz: ");

// var n= Convert.ToInt32(Console.ReadLine());
// int [] yazilandizi = new int[n];  
 
// Console.WriteLine($"Lütfen {n} sayı giriniz. ");

// for (int i = n; i > 0; )
// {
//     System.Console.WriteLine($" {i} . sayıyı giriniz");
//     yazilandizi[(--i)]= Convert.ToInt32(Console.ReadLine());
//     for (int a=0; a<n ; a++)
//         for ()
//     System.Console.WriteLine(yazilandizi[n]);} 

Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
int n= Convert.ToInt32(Console.ReadLine());
int [] yazilandizi = new int[n];  
Console.WriteLine($"Lütfen {n} sayı giriniz. ");

for (int i = n; i > 0;)
{
   System.Console.WriteLine($" {i} . sayıyı giriniz");
    yazilandizi[(--i)]= Convert.ToInt32(Console.ReadLine());
   
}
for (int j = 0; j < yazilandizi.Length; j++)
    {
        int m = yazilandizi[j];
        if (m%2==0)
        {
            System.Console.WriteLine(yazilandizi[j]);
        }
    }
 










   
