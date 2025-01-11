/*
 * CSE212 
 * (c) BYU-Idaho
 * 09-Prove
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */

using prove_01;

Console.WriteLine("\n======================\nProve 1 - Arrays / Lists\n======================");
ArraysTester.Run();

// Testing MultiplesOf
var multiples = ArrayUtilities.MultiplesOf(3, 5);
Console.WriteLine("Multiples of 3: " + string.Join(", ", multiples));


// Testing RotateListRight
var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var rotated = ArrayUtilities.RotateListRight(data, 5);
Console.WriteLine("Rotated List: " + string.Join(", ", rotated));
