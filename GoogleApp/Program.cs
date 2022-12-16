static int GetInput()
{
   try
   {
      string? input = Console.ReadLine();
      if (input == "q") Environment.Exit(0);
      int convertedInput = Convert.ToInt32(input);
      if (convertedInput == 0) throw new Exception("Atılan zar değeri 0 olamaz.");
      return convertedInput;
   }
   catch (Exception)
   {
      Console.WriteLine("Değer alınırken hata ile karşılaşıldı. Hata mesajı: ");
      Console.WriteLine("Lütfen tekrar deneyiniz!");
   }

   return GetInput();
}

Console.WriteLine("Lütfen atmak istediğiniz zar sayısını giriniz. " +
                  "Uygulamadan çıkmak için q tuşuna basıp enter tuşuna basınız.");

int dice_count = GetInput();

Console.Clear();

int[] dice_results = new int[dice_count];
Random randNumber = new Random();

foreach (var dice  in dice_results.Select(((count, index) => new {index, count})))
{
   int rand = randNumber.Next(0, 21);
   Console.WriteLine(rand);
   dice_results[dice.index] = rand;
}

int average = Convert.ToInt32(dice_results.Sum() / dice_results.Length);
Console.WriteLine("Ortalama: "+ average);
switch (average)
{
   case <3:
      Console.WriteLine("Crit Fail attınız. Kendinize Hasarınız: "+ average);
      break;
   case <8:
      Console.WriteLine("Zayıf hasar veriyorsunuz. Hasarınız: "+ average);
      break;
   case <12:
      Console.WriteLine("Orta dereceli hasar verdiniz. Hasarınız: "+ average);
   break;
   case <19:
      Console.WriteLine("Yüksek hasar veriyorsunuz. Hasarınız: "+ average);
   break;
   case <21:
      Console.WriteLine("İnanılmazz!!! Crit hasar veriyorsunuz. Hasarınız: "+ average);
   break;
}
Console.ReadLine();
