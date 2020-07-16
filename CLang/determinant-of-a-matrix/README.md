# Determinant of a Matrix

Program for calculate simply determinant of _NxN_ matrix written on *C*.

* Compile using *GCC* ```gcc -o main main.c -lm```

## What is Determinant of a Matrix?

Determinant of a Matrix is a special number that is defined only for square matrices (matrices which have same number of rows and columns). 
Determinant is used at many places in calculus and other matrix related algebra, 
it actually represents the matrix in term of a real number which can be used in solving system of linear equation and finding the inverse of a matrix.

## How to calculate?

The value of determinant of a matrix can be calculated by following procedure –
For each element of first row or first column get cofactor of those elements and then multiply the element with the determinant of the corresponding cofactor,and finally add them with alternate signs. 
As a base case the value of determinant of a 1*1 matrix is the single value itself.
**Cofactor** of an element, is a matrix which we can get by removing row and column of that element from that matrix.

**Determinant of 2x2 Matrix:**

![Determinant of 2x2 Matrix](http://csyntax.net/img/matrix/det2x2.svg)

**Determinant of 3x3 Matrix:**

![Determinant of 3x3 Matrix](http://csyntax.net/img/matrix/det3x3.svg)