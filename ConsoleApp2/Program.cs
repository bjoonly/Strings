using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            //1
            //string[] words = new string[] { "Down", "the", "way", "nights", "are", "dark", "And", "the", "sun", "shines", "daily", "on", "the", "mountain", "top", "I", "took", "a", "trip", "on", "a", "sailing", "ship", "And", "when", "I", "reached", "Jamaica", "I", "made", "a", "stop" };

            //int imin;
            //string tmp;

            //foreach (var w in words)
            //    Console.Write(w + " ");
            //Console.WriteLine("\n");
            //for (int i = 0; i < words.Length - 1; i++)
            //{
            //    imin = i;
            //    for (int j = i + 1; j < words.Length; j++)
            //    {

            //        if (Char.ToUpper(words[j][0]) < Char.ToUpper(words[imin][0]))
            //        {
            //            imin = j;
            //        }
            //    }
            //    if (imin > i)
            //    {
            //        tmp = words[i];
            //        words[i] = words[imin];
            //        words[imin] = tmp;
            //    }

            //}
            //foreach (var w in words)
            //    Console.Write(w + " ");

            //Console.WriteLine('\n');
            //Console.ReadKey();

            //2
            //Console.WriteLine("Enter line:");
            //string line = Console.ReadLine();
            //string reverse = new string(line.Reverse().ToArray());
            //Console.WriteLine(reverse);
            //Console.ReadKey();

            //3
            //Console.WriteLine("Enter line:");
            //string line1 = Console.ReadLine();
            //int posFirstDot = -1, posSecondDot = -1, count = 0;
            //for (int i = 0; i < line1.Length; i++)
            //{
            //    if (line1[i] == '.')
            //    {
            //        count++;
            //        if (count == 1)
            //            posFirstDot = i;
            //        else if (count == 2)
            //        {
            //            posSecondDot = i;
            //            break;
            //        }
            //    }
            //}
            //if (posFirstDot == -1 || posSecondDot == -1)
            //    Console.WriteLine("There are no 2 dots in the line.");
            //else
            //{
            //    for (int i = posFirstDot; i < posSecondDot; i++)
            //    {
            //        if (line1[i] == ' ')
            //        {
            //            line1 = line1.Remove(i, 1);
            //            posSecondDot--;
            //            --i;
            //        }
            //    }
            //    Console.WriteLine(line1);
            //}
            //Console.ReadKey();

            //4
            //Console.WriteLine("Enter line:");
            //string line3 = Console.ReadLine();
            //string res = new string(line3.Reverse().ToArray());
            //if (line3 == res)
            //    Console.WriteLine("Palindrome.");
            //else
            //    Console.WriteLine("Not a palindrome.");
            //Console.ReadKey();

            // 5
            //string line4 = "Down the way nights are dark And the sun shines daily on the mountain top I took a trip on a sailing ship And when I reached Jamaica I made a stop";
            //Console.WriteLine(line4);
            //Console.WriteLine("Enter pos: ");
            //int pos1 = int.Parse(Console.ReadLine());
            //string[] wordsInLine4 = line4.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //if (pos1 <= wordsInLine4.Length && pos1 > 0)
            //    Console.WriteLine(wordsInLine4[pos1 - 1][0]);
            //else
            //    Console.WriteLine("Incorrect position.");
            //Console.ReadKey();

            // 6
            //string line5 = "Down the way nights are dark And the sun shines daily on the mountain top I took a trip on a sailing ship And when I reached Jamaica I made a stop";
            //Console.WriteLine(line5);
            //Console.WriteLine("Enter length(>3):");
            //int lengthLine5 = int.Parse(Console.ReadLine());
            //string[] wordsInLine5 = line5.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //if (lengthLine5 >= 3)
            //{
            //    for (int i = 0; i < wordsInLine5.Length; i++)
            //    {
            //        if (wordsInLine5[i].Length == lengthLine5)
            //        {
            //            wordsInLine5[i] = wordsInLine5[i].Remove(lengthLine5 - 3);
            //            wordsInLine5[i] += "$$$";
            //        }
            //    }
            //    line5 = String.Join(" ", wordsInLine5);
            //    Console.WriteLine(line5);
            //}
            //else
            //    Console.WriteLine("Incorrect length of word.");
            //Console.ReadKey();

            // 7
            //string line6 = "Down the way nights are dark And the sun shines daily on the mountain top I took a trip on a sailing ship And when I reached Jamaica I made a stop";
            //Console.WriteLine(line6);
            //int countUpper = 0, countLower = 0;
            //double percentageUp, percentageLow;
            //for (int i = 0; i < line6.Length; i++)
            //{
            //    if (char.IsUpper(line6[i]))
            //        countUpper++;
            //    else if (char.IsLower(line6[i]))
            //        countLower++;
            //}
            //percentageLow = countLower / (double)line6.Length * 100;
            //percentageUp = countUpper / (double)line6.Length * 100;
            //Console.WriteLine($"Characters: {line6.Length}");
            //Console.WriteLine($"Upper: {percentageUp}%");
            //Console.WriteLine($"Lower: {percentageLow}%");
            //Console.ReadKey();

            //8

            //Console.WriteLine("Enter line:");
            //string line7 = Console.ReadLine();
            //Console.WriteLine("Enter added line:");
            //string addedText = Console.ReadLine();
            //Console.WriteLine("Enter position:");
            //int pos2 = int.Parse(Console.ReadLine());
            //if (pos2 > 0 && pos2 <= line7.Length)
            //{
            //    line7 = line7.Insert(pos2 - 1, addedText);
            //    Console.WriteLine(line7);
            //}
            //else
            //    Console.WriteLine("Ivalid position.");
            //Console.ReadKey();

            //9
            //string line8 = "Down the way nights are dark And the sun shines daily on the mountain top I took a trip on a sailing ship And when I reached Jamaica I made a stop";
            //Console.WriteLine(line8);
            //Console.WriteLine("Enter old sequance:");
            //string sequance = Console.ReadLine();
            //Console.WriteLine("Enter new sequance:");
            //string newSequance = Console.ReadLine();
            //string newText = line8.Replace(sequance, newSequance);
            //Console.WriteLine(newText);
            //Console.ReadKey();

            //10
            //char[,] letters = new char[,]{
            //                               {'c','z','b','a', 'l' },
            //                               { 'a','c','t','o','p' },
            //                               { 't','o','w','n','e' },
            //                               { 'b','y','t','r','n' },
            //                               { 'k','n','i','f','e' }
            //                             };
            //for (int i = 0; i <= letters.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= letters.GetUpperBound(1); j++)
            //    {
            //        Console.Write(letters[i, j] + " ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("Enter word:"); //cat act knife pen town 
            //string word = Console.ReadLine();
            //string line9 = " ";
            //bool searchResults = false;
            //int r, c;
            //for (int i = 0; i <= letters.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= letters.GetUpperBound(1); j++)
            //    {
            //        line9 += letters[i, j];
            //    }
            //    c = line9.IndexOf(word);
            //    if (c != -1)
            //    {
            //        r = i;
            //        Console.WriteLine($"Word in row {r + 1} in col {c + 1} (horizontally).");
            //        searchResults = true;
            //        break;
            //    }
            //    line9 = "";
            //}
            //if (!searchResults)
            //{
            //    for (int i = 0; i <= letters.GetUpperBound(0); i++)
            //    {
            //        for (int j = 0; j <= letters.GetUpperBound(1); j++)
            //        {
            //            line9 += letters[j, i];
            //        }
            //        r = line9.IndexOf(word);
            //        if (r != -1)
            //        {
            //            c = i;
            //            Console.WriteLine($"Word in row {r + 1} in col {c + 1} (verticaly).");
            //            searchResults = true;
            //            break;
            //        }
            //        line9 = "";
            //    }
            //}
            //if (!searchResults)
            //    Console.WriteLine("Word not found.");
           // Console.ReadKey();

            // 11
            //string line10 = "  Down  the  way nights are dark  And the sun shines   daily on the   top I  took   a trip   on a sailing ship    And when I reached Jamaica I made a   stop  ";
            //Console.WriteLine(line10);
            //string[] wordsInLine9 = line10.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //line10 = string.Join("*", wordsInLine9);
            //Console.WriteLine(line10);
            //Console.ReadKey();


            // 12
            //string line11 = "Down the way nights are dark And the sun shines daily on the top I took a trip on a sailing ship And when I reached Jamaica I made a stop";
            //int maxLength;
            //string[] wordsInLine10 = line11.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //maxLength = wordsInLine10[0].Length;
            //for (int i = 0; i < wordsInLine10.Length; i++)
            //{
            //    if (wordsInLine10[i].Length > maxLength)
            //        maxLength = wordsInLine10[i].Length;
            //}
            //for (int i = 0; i < wordsInLine10.Length; i++)
            //{
            //    if (wordsInLine10[i].Length == maxLength)
            //        wordsInLine10[i] = wordsInLine10[i].Replace('a', 'b');
            //}
            //Console.WriteLine(line11);
            //line11 = String.Join(" ", wordsInLine10);
            //Console.WriteLine(line11);
            //Console.ReadKey();

            //13
            //Console.WriteLine("Enter line:");
            //string line12 = Console.ReadLine(), lineWords, lineNumbers, lineRNumbers;
            //StringBuilder sbWords = new StringBuilder(), sbRNumbers = new StringBuilder(), sbNumbers = new StringBuilder();
            //string[] wordsInLine11 = line12.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < wordsInLine11.Length; i++)
            //{
            //    if (int.TryParse(wordsInLine11[i], out int numI))
            //        sbNumbers.Append(wordsInLine11[i] + " ");

            //    else if (double.TryParse(wordsInLine11[i], out double numD))
            //        sbRNumbers.Append(wordsInLine11[i] + " ");
            //    else
            //        sbWords.Append(wordsInLine11[i] + " ");
            //}

            //lineWords = sbWords.ToString();
            //lineNumbers = sbNumbers.ToString();
            //lineRNumbers = sbRNumbers.ToString();

            //Console.WriteLine("Numbers: " + lineNumbers);
            //Console.WriteLine("Regular numbers: " + lineRNumbers);
            //Console.WriteLine("Words: " + lineWords);
            //Console.ReadKey();

            //14
            //string line13 = "Down the way nights are dark And the sun shines daily on the mountain top I took a trip on a sailing ship And when I reached Jamaica I made a stop";
            //Console.WriteLine(line13);

            //string[] wordsInLine12 = line13.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < wordsInLine12.Length; i++)
            //{
            //    if (wordsInLine12[i].Length < 5)
            //    {
            //        for (int j = i; j < wordsInLine12.Length - 1; j++)
            //            wordsInLine12[j] = wordsInLine12[j + 1];

            //        Array.Resize(ref wordsInLine12, wordsInLine12.Length - 1);
            //        i--;
            //    }
            //}

            //line13 = String.Join(" ", wordsInLine12);
            //Console.WriteLine(line13);
            //Console.ReadKey();

            //15
            //Console.WriteLine("Enter first number:");
            //string line14 = Console.ReadLine();
            //Console.WriteLine("Entr second number:");
            //string line15 = Console.ReadLine();
            //string resSum;
            //int num1, num2, num3 = 0, l, sum;
            //char[] firstNumber = (line14.Reverse().ToArray());
            //char[] secondNumber = line15.Reverse().ToArray();

            //l = (line14.Length > line15.Length ? line14.Length : line15.Length) + 1;
            //char[] result = new char[l + 1];
            //for (int i = 0; i < l - 1; i++)
            //{
            //    if (i < firstNumber.Length)
            //        num1 = int.Parse(firstNumber[i].ToString());
            //    else
            //        num1 = 0;

            //    if (i < secondNumber.Length)
            //        num2 = int.Parse(secondNumber[i].ToString());
            //    else
            //        num2 = 0;
            //    sum = num1 + num2 + num3;
            //    num3 = sum / 10;
            //    result[i] = Convert.ToChar((sum % 10).ToString());
            //}
            //if (num3 != 0)
            //    result[l - 1] = Convert.ToChar(num3.ToString());
            //result = result.Reverse().ToArray();
            //resSum = new string(result);
            //Console.WriteLine("Sum: " + resSum);
            //Console.ReadKey();
        }
    }

}

