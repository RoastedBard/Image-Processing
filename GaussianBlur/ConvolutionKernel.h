#ifndef CONVOLUTIONKERNEL_H
#define CONVOLUTIONKERNEL_H

#include <math.h>
#include <stdio.h>
#include <stdlib.h>

typedef struct
{
    double  *data;
    double  deviation;
    int     center;
    int     size;
} ConvolutionKernel;

double generate2DGaussianNumber(double deviation, int x, int y)
{
    double result = 0;

    double first = 1.0 / (2.0 * 3.141592 * pow(deviation,2));
    double second = exp(-(double)(x*x + y*y)/2.0*pow(deviation,2));
    result = first*second;

    return result;
}

void ConvolutionKernel_initialize(ConvolutionKernel &kernel, int size, double deviation)
{
    kernel.size = size;
    kernel.center = size / 2;
    kernel.deviation = deviation;
    
    kernel.data = NULL;
    kernel.data = (double*)malloc((kernel.size * kernel.size) * sizeof(double));
}

void ConvolutionKernel_destroy(ConvolutionKernel &kernel)
{
    kernel.size = 0;
    kernel.center = 0;
    kernel.deviation = 0;

    free(kernel.data);
}

void ConvolutionKernel_generate(ConvolutionKernel &kernel)
{
    if(kernel.data == NULL)
        return;
    /* Координаты верхнего левого элемента матрицы, взятые с учетом того, что центр матрицы это (0,0). Например:
    *
    *   Y
    *    ^
    *    | (-1,1)  (0,1)  (1,1)
    *    | (-1,0)  (0,0)  (1,0)
    *    | (-1,-1) (0,-1) (1,-1)
    *    -----------------------> 
    *                            X
    */
    int algorhitmInc_y =  kernel.center;
    int algorhitmInc_x = -kernel.center;

    int i = 0, j = 0;

    for(i = 0; i < kernel.size; ++i)
    {
        algorhitmInc_x = -kernel.center;
        for(j = 0; j < kernel.size; ++j)
        {
            kernel.data[kernel.size * i + j] = generate2DGaussianNumber(kernel.deviation, algorhitmInc_x, algorhitmInc_y);
            ++algorhitmInc_x;
        }
        --algorhitmInc_y;
    }
}

#endif