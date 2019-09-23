# WordUnscrambler
WordUnscrambler is a console application that allows the User to find scrambled words through a file or a manual input.

-------------------------------------------------------------------------------------------------------

The purpose of this console application is to showcase some of my current knowledge on c# as well as my programming principles.

**WordUnscrambler** Allows the user to enter scrambled words and search for matches within a list that contains the correct/unscrambled version of the words. The user may choose to search for words manually, by writting the scrambled words while the application is running or he may choose to enter a file with scrambled words which will be matched against a list of unscrambled words, all the user would need to do is input the full path to the file including its name and extensions.

The program is also ready to handle certain exceptions in case the user types in some sort of unrecognized input or if, for example, the path to the file is invalid.

**A Unit Test class will be added later on.**

-------------------------------------------------------------------------------------------------------

**General descritpion of the Scripts**


**[Data](https://github.com/PauloB04/WordUnscrambler/blob/master/Data.cs)** Is a part of the DataManagement library. **Data** Is a struct that contains most of the content used throughout the program. It allows the other classes to get or set the data needed to make the program work. 

**[MatchedWords](https://github.com/PauloB04/WordUnscrambler/blob/master/MatchedWords.cs)** Is a part of the DataManagement library, it was created to store an unscrambled word with its match. A list of this class is created and used by the **unscrambler** class.

**[FileReader](https://github.com/PauloB04/WordUnscrambler/blob/master/FileReader.cs)** Is part of the Workers library,**FileReader** was created for the purposes of facilitating the reading of files. It checks for path validity and cacthes any unexpected exceptions that might otherwise cause the application to stop running.

**[Input](https://github.com/PauloB04/WordUnscrambler/blob/master/Input.cs)** Is part of the Workers library, the **Input** class contains the instructions on how to execute the program and manages some of the user input. It then stores the user input into **Data**.

**[Unscrambler](https://github.com/PauloB04/WordUnscrambler/blob/master/Unscrambler.cs)** Is part of the Workers library, it is essentially the heart or core of the application. **Unscrambler** takes the data acquired by the **Input** class and uses it to look through a list of unscrambled words for matches and when a match is found, it takes the scrambled word and its matched word to add it to a list of **MatchedWords**, which is then displayed to the user.

**[Program](https://github.com/PauloB04/WordUnscrambler/blob/master/Program.cs)** Is the part of the application that makes use of the different libraries to call on methods and run the application.

**The Files**

**[MyFirstFile](https://github.com/PauloB04/WordUnscrambler/blob/master/MyFirstFile.txt)** Contains a small, preset list of scrambled words to test the "file" functionality of the program.

**[dictionary](https://github.com/PauloB04/WordUnscrambler/blob/master/dictionary.txt)** Is the file that holds the list of unscrambled words used by the **Unscrambler** class to match against the scrambled words provided by the user.
