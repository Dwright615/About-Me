# About-Me
I'm a recent graduate with a B.S. in Professional Computer Science from Middle Tennessee State University. My degree is accredited by the Accreditation Board for Engineering and Technology, Inc. or ABET. I am interested in all aspects of sofware creation, testing, and debugging as well as database managment. I hope to master front end and back end technologies and to gain the skills to be a full-stack developer.

## About this repository
This repositiory contains examples of source code that I've written as well as the language, platform, and environment that the project was created in. Each project will also contain a brief explanation of its purpose and funtionality as well.

## Language Examples
* [C++](https://https://github.com/Dwright615/About-Me/tree/master#c "C++ Examples")
* [C#](https://github.com/Dwright615/About-Me/blob/master/README.md#c-1 "C# Examples")

### C++
These are a few programs written in c++ ranging from simple to fairly complex. Provided below are links to the source code along with a brief description of the program. All of these are console applications and  were written using Microsoft Visual Studio. 

* [Back Tracking Algorithm](https://github.com/Dwright615/About-Me/blob/master/backTracking.cc "backTracking.cc") (Driver).
    - In this program I used the "Back Tracking Algorithm" to solve a puzzle known as the "N Queens Problem". The algortithm itself is implemented in [nQueens.h](https://github.com/Dwright615/About-Me/blob/master/nQueens.h "nQueens.h") (Header). The user is asked to enter a number('N') of Queens, think chess, to place on a board. The program will create a chess board of N x N deminsions. It uses the backtracking algorithm to place the queens across the board in such a way that they could not attack one another. A detailed breakdown of the problem can be found [here](https://developers.google.com/optimization/puzzles/queens "NQueens Explained").
    
* [Fibonacci Sequence](https://github.com/Dwright615/About-Me/blob/master/fibonacci.cc "fibonacci.cc")
    - This is an iterative solution to the famous "Fibonacci Sequence". The Fibonacci sequence is a series of numbers where a number is found by adding up the two numbers before it. Starting with 0 and 1, the sequence goes 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, and so forth. Written as a rule, the expression is xn = xn-1 + xn-2.[Source](https://www.livescience.com/37470-fibonacci-sequence.html "Fibonacci explained").

* [Simple BubbleSort](https://github.com/Dwright615/About-Me/blob/master/bubbleSort.cc "bubbleSort.cc")
    - This is a simple program that implements a method "sort" that takes the number of elements of an Int array(Hard coded in this version) and then sorts the integers entered by the user into ascending order. Also there is a "swap" function implemented inside the "sort" fuction which uses the array adresses as arguments and pointers as local variables to swap values if necessary.
    
### C#
Here are a few examples of C# programs, some of which are console will others are variations of Windows forms. 

* [Alarm Clock](https://github.com/Dwright615/About-Me/blob/master/alarmClock.cs "alarmClock.cs")
    - This Particular alarm Clock simply shows how to implement your own "alarmClock" class and use the built-in "DateTime.Now" to set your clock then choose a time to set your alarm.(Hard coded in this case)
    
* [Using LINQ](https://github.com/Dwright615/About-Me/blob/master/linq.cs "linq.cs")
    - In this LINQ(Language Integrated Query) example I created an array or "Invoice" objects ([The invoice implementation can be found here](https://github.com/Dwright615/About-Me/blob/master/invoice.cs "invoice.cs")) then various queries are run on the array to show how LINQ can be used. Find more information about LINQ [here](http://searchwindevelopment.techtarget.com/definition/LINQ "What is LINQ?").
    
* [Simple Paddle Game](https://github.com/Dwright615/About-Me/blob/master/paddle.cs "paddle.cs")
    - "paddle.cs" is the driver but the real magic happens in the [Form1.cs](https://github.com/Dwright615/About-Me/blob/master/Form1.cs "Form1.cs").  This app demonstrates how we can use a Windows Form to creat a pong game. The game is a one player game and the goal is for the player to defend the bottom border of the window and keep the bouncing ball (square) from touching the bottom. All other sides of the window should bounce the ball around and if the ball hits the players paddle then it will speed up by an increment of one each time. If the ball gets past the players paddle then the ball will reset to the center of the screen and its speed will reset back to 1.
    
* Below are a couple of screenshots of forms I created using Windows forms in C#
    - This is a form that could be used to indicate iformation about an employee
        - ![alt text](http://i.imgur.com/2SEc6TW.png "Employee Form")
        
    - This is a mock up of an IRS information form
        - ![alt text](http://i.imgur.com/1h4qBBt.png "IRS Form")
