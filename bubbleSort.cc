#include <iostream>
using namespace std;

void sort(int);
void swap(int*, int*);

int a[10];

int main() {
	int i;

	for (i = 0; i < 10; i++) {
		cout << "Enter array element #" << i << ": ";
		cin >> a[i];
	}
	sort(10);

	cout << "Here is the array sorted:" << endl;
	for (i = 0; i < 10; i++) {
		cout << a[i] << " ";
	}
	system("PAUSE");
	return 0;
}

// A type of bubble sort algorithm to sort an array with n elements 
void sort(int n){
	int i, j, low;

	for (i = 0; i < n - 1; i++){		// This portion of the loop finds the lowest element
										// between i and n -1. The index is stored in "low"
		low = i;
		for (j = i + 1; j < n; j++) {
			if (a[j] < a[low]) {
				low = j;
			}
		}
		if (i != low){
			swap(&a[i], &a[low]);		// Swap values if needed.
		}
	}
}

// Swap the values pointed to by p1 and p2.
void swap(int *p1, int *p2) {
	int temp = *p1;
	*p1 = *p2;
	*p2 = temp;
}
