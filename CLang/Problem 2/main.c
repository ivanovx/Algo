#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i, n, t1 = 0, t2 = 1, nextTerm;

    printf("Enter n: ");
    scanf("%d", &n);

    printf("Fibonacci: ");

    for (i = 1; i <= n; ++i)
    {
        printf("%d, ", t1);

        nextTerm = t1 + t2;
        t1 = t2;
        t2 = nextTerm;
    }

    return 0;
}
