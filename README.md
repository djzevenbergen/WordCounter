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

1. User enters a sentence
  * Input: "There is a rat over there"
  * Output: "Input recieved. Please enter a word that you want to count the instances of: "
2. User enters a word
  * Input: "There"
  * Output: "The word 'there' occurs 2 times in 'There is a rat over there'"
3. User enters an word that is not in the sentence
  * Input: "than"
  * Output: "The word 'than' occurs 0 times in 'There is a rat over there'"
4. User enters an empty sentence
  * Input: "" or "         "
  * Output: "Please enter sentence to be searched"
5. User enters an empty word
  * Input: "" or "          "
  * Output: "Please enter a word!"



---
## Known Bugs


## Support

_Email: nitundatta8@gmail.com_

---
## Built With

## Useful tools




### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Nitun Datta & DJ Zevenbergen_**
