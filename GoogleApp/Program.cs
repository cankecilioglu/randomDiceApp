int dice_count = Convert.ToInt32(Console.ReadLine());
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
      Console.WriteLine("Crit Fail attınız. Kendinize hasarınız");
      break;
   case <8:
      Console.WriteLine("Zayıf hasar veriyorsunuz. Rakip size zort diyor.");
      break;
   case <12:
      Console.WriteLine("Orta şekerli hasar verdiniz. Helal la");
   break;
   case <19:
      Console.WriteLine("Yüksek hasar veriyorsunuz. Rakip zort etti.");
   break;
   case <21:
      Console.WriteLine("Crit hasar veriyorsunuz ulaaaa. Sümüğü çıktı usta");
   break;
}
Console.ReadLine();
