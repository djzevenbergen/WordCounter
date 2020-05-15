# _Word Counter_

#### _Counts instances of a word within a sentence. 5/14/2020_

### Made by DJ Zevenbergen
## Description

_This C# console application allows a user enters a sentence and a word, and counts all instances of that word within the sentence. It uses BDD and TDD to guide the design._


## Setup/Installation Requirements

* Clone repository from GitHub in terminal or console
* ensure that C#/.netcore2.2 is installed on your computer
* dotnet run
* if you want to test, locate to the WordCounter.Tests directory and run "dotnet test"


## Specs

1. User enters a sentence and a word, and the program returns how many times that word occurs in the sentence
  * Input: "There is a rat over there", "there"
  * Output: "The word 'there' occurs 2 times in 'There is a rat over there'"
2. User enters an word that is not in the sentence, and the program returns 0
  * Input: "than"
  * Output: "The word 'than' occurs 0 times in 'There is a rat over there'"
3. User enters an empty sentence, and the program responds with a prompt
  * Input: "" or "         "
  * Output: "Please enter sentence to be searched"
4. User enters an empty word, and the program responds with a prompt
  * Input: "" or "          "
  * Output: "Please enter a word!"
5. User enters a sentence and a word, where the sentence contains words that contain the word, and the program doesn't count those partial matches
  * Input: "Cat catcat cat", "cat"
  * Output: "The word 'cat' appears 2 times in the sentence "Cat catcat cat"
6. User can save summary of actions into .txt file
  * Input: Save? Y
  * Output: saved file


## Support

_Open an issue_


## Built With
C#

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_DJ Zevenbergen_**
