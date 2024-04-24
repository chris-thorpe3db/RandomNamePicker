/*
 * Random Name Picker is a simple program that allows you to add names to a list and pick a random name from that list.
 * Copyright (c) 2024 Christopher Thorpe.
 *
 * RandomNamePicker is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * RandomNamePicker is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with RandomNamePicker. If not, see <https://www.gnu.org/licenses/>.
 */

using System;

namespace RandomNamePicker {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Random Name Picker \nCopyright 2024 Christopher Thorpe.");
            Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY; for details type 'show w'. This is free software, and you are welcome to redistribute it under certain conditions; type 'show c' for details. \n");
            Console.WriteLine("Type a name to add it to the list. \nType 'p' to pick a random name. \nType 'r' to remove the last name from the list. \nType 'rr' to reset the list. \nType 'l' to show all names in the list. \nType 'q' to quit the program.");
            List<string> names = new List<string>();
            string? consoleInput = null;
            while (true) {
                consoleInput = Console.ReadLine();
                Console.WriteLine();
                if (consoleInput == "show w") {
                    Console.WriteLine("This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. \nFor more information, visit https://www.gnu.org/licenses/.");
                } else if (consoleInput == "show c") {
                    Console.WriteLine("This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version. \nFor more information, visit https://www.gnu.org/licenses/.");
                } else
                if (consoleInput == "q") {
                    Console.WriteLine("Quitting...");
                    break;
                } else if (consoleInput == "p") {
                    if (names.Count == 0) {
                        Console.WriteLine("There are no names in the list.");
                    } else {
                        Random random = new Random();
                        int randomIndex = random.Next(names.Count);
                        Console.WriteLine(names[randomIndex]);
                    }
                } else if (consoleInput == "l") {
                    if (names.Count == 0) {
                        Console.WriteLine("There are no names in the list.");
                    } else {
                        Console.WriteLine("Names in the list:");
                        foreach (string name in names) {
                            Console.WriteLine(name);
                        }
                    }
                } else if (consoleInput == "r") {
                    if (names.Count == 0) {
                        Console.WriteLine("There are no names in the list.");
                    } else {
                        Console.WriteLine("You are about to remove " + names[names.Count - 1] + " from the list. Are you sure? (y/n)");
                        consoleInput = Console.ReadLine();
                        if (consoleInput == "y") {
                            Console.WriteLine(names[names.Count - 1] + " has been removed from the list.");
                            names.RemoveAt(names.Count - 1);
                        }
                    }
                } else if (consoleInput == "rr") {
                    Console.WriteLine("You are about to reset the list. This CANNOT be undone. Are you absolutely sure? (y/n)");
                    consoleInput = Console.ReadLine();
                    if (consoleInput == "y") {
                        names.Clear();
                        Console.WriteLine("The list has been reset.");
                    }
                } else if (consoleInput is not null){
                    names.Add(consoleInput);
                } else {
                    Console.WriteLine("Invalid input.");
                }
                Console.WriteLine();
            }
        }
    }
}