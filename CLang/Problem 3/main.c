#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n, i;
    unsigned long long factorial = 1;

    printf("Enter n: ");
    scanf("%d",&n);

    if (n < 0)
    {
        printf("Error!");
    }
    else
    {
        for(i=1; i<=n; ++i)
        {
            factorial *= i;
        }
        printf("Factorial: %d = %llu", n, factorial);
    }

    return 0;
}
