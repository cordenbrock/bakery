# Pierre's Bakery

#### By Cory Nordenbrock
##### 12/11/20

## _What_ does it do?

* Pierre's Bakery is a basic console app that prompts a user with a friendly greeting and a menu to order bread and pastries from. After accepting the user's order and crunching the numbers for all of Pierre's sweet deals, the app returns the a transaction message that displays the total cost of the order and Pierre's signature gratitude.

## _Why_ does it do?

* This project was prompted by the wonderful people at [Epicodus](https://www.epicodus.com/) as a simple exercise in building an interactive console application--with an added development emphasis in using TTD. Utilizing MSTests for unit testing, this app currently runs eight successful tests to ensure proper functionality and maintain spiffiness of three custom classes that do all the under-the-hood heavy lifting for Pierre's Bakery (note: an establishment renowned for its fictionality).

## Setup Instructions

   _**Note**: [.NET Core](https://dotnet.microsoft.com/download) must be installed for the following instructions (v 2.2 for current source code, later versions may be used by editing the ` <TargetFramework> ` element in Bakery.csproj to reflexct the correct version)._

* To run program:

1. Clone this repository: ` git clone https://github.com/cordenbrock/bakery.git `
2. Navigate to this specific directory: ` cd bakery/Bakery `
3. Run the program in in your terminal with a ` dotnet run ` command (this will install the necessary dependencies and build the app).
4. To exit, ` ctrl + C ` on Windows or ` cmd + C ` on Mac.

* To run program tests:

5. Navigate to this specific directory: ` cd bakery/Bakery.Tests `. If navigating from the aforementioned directory, be sure to first navigate "up" a folder, i.e. prepend a ` ../ ` to the path.
6. Run the tests with a ` dotnet test ` command.

## Built with/Tools used

* _C# v 7.3_
* _.NET Core v 2.2_
* _dotnet script, REPL_
* _MSTests_

### Known Bugs/Future Improvements

* Exception handling should be added

### Legal

MIT License, (c) 2020 Cory Nordenbrock