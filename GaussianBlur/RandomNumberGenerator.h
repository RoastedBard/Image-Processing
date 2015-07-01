#ifndef RANDOMNUMBERGENERATOR_H
#define RANDOMNUMBERGENERATOR_H

#include <time.h>
#include <stdlib.h>

void swap_int(int* a, int* b)
{
    int tmp = *a; *a=*b; *b=tmp; 
}

inline int rand_int_hi_lo(int upper, int lower)
{
    return((rand() % (upper-lower+1)) + lower);
}

int rand_int(int a,int b)
{
    if (b > a) 
        swap_int(&a,&b);
    return rand_int_hi_lo(a,b);
}
#endif