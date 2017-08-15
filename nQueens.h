//Author: David Wright
// "nQueens.h"
// This is the header and implementation file for nQueens solution. It contains methods which will take a number 'n'
// and create a board of n X n size. The program will check to see which coordinates on the board are promising to
// place a Queen (think of a Queen in Chess) on and will use a recursive method to solve the problem. the recursive method will
// backtrack if necessary to make sure that the problem is solved correctly.

#include <string>
#include <iostream>

using std::string;


bool printNQueensSolution(int, string);
bool solve(char**, int, int);
bool isPromising(char**, int, int, int);
void display(char**, int);

/* This is the  function which will create a 2d array which will represent our board. After the board is created the fuction 
will check to see if there is no solution, if  so it will inform the user then return false. If a soution does exist then
it will display the solved board to the user*/
bool printNQueensSolution(int n, string outputFilename) {
	char** board = new char*[n];
	for (int i = 0; i < n; ++i)
		board[i] = new char[n];
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++)
			board[i][j] = '-';
	}
	if (solve(board, 0, n) == false)
	{
		std::cout << "Solution does not exist" << std::endl;
		return false;
	}
	display(board,n);
	return true;
}

/*** BACKTRACKING HERE ***/
/*This is the method which actually solves the problem and recursively calls itself.*/
bool solve(char** board, int col, int n)
{
	if (col >= n)
		return true;
	for (int i = 0; i < n; i++)
	{ 
		if (isPromising(board, i, col, n))
		{
			board[i][col] = 'Q';
			if (solve(board, col + 1, n) == true)			// Recursive call
				return true;
			board[i][col] = '-';
		}
	}
	return false;
}

/*This is the method which tests to see if  any of the adjacent coordinates contains a queen or 
if a queen can attack from a diagonal line*/
bool isPromising(char** board, int row, int col, int n)
{
	int i, j;
	for (i = 0; i < col; i++){
		if (board[row][i] == 'Q')
			return false;
	}
	for (i = row, j = col; i >= 0 && j >= 0; i--, j--){
		if (board[i][j] == 'Q')
			return false;
	}
	for (i = row, j = col; j >= 0 && i < n; i++, j--){
		if (board[i][j] == 'Q')
			return false;
	}
	return true;				// A queen can be placed
}


/*This method will display the solved board if it exist*/
void display(char** board, int n) {
	for (int i = 0; i < n; i++){
		for (int j = 0; j < n; j++)
			std::cout << board[i][j] << "  ";
		std::cout << std::endl;
	}
}
