// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutajal sisestada tema nimi
// rAKENDUS TERVITAB KASUTAJAT NIMEPIDI

Console.WriteLine("Enter your name:"); // Output
// string - sõne
string userName;

userName = Console.ReadLine();  // input

Console.WriteLine("Hello" + ", " + userName +"!"); // Output
// string interpolation


Console.WriteLine($"Hello, {userName}!");  // Output  