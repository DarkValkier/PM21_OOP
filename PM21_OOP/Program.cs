using character;

Character player1 = new Character("Vasya", 100, 3, 0);
Character player2 = new Character("Petya", 85, 5, 0);

player1.showStats();
Console.WriteLine();
player2.showStats();
Console.WriteLine();

player1.attack(player2);
player2.attack(player1);

Console.WriteLine("After attack:");
player1.showStats();
Console.WriteLine();
player2.showStats();