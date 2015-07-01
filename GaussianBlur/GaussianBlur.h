#ifndef GAUSSIANBLUR_H
#define GAUSSIANBLUR_H

#include "ConvolutionKernel.h"

//This is really ugly, I know :( 
double sample(double array[], int x, int y, int width, int height)
{
    if(x >= width)
    {
        do
        {
            x = x - width;
        }while(x >= width);
    }
    else if(x < 0)
    {
        do
        {
            x = x + width;
        }while(x < 0);
    }
    if(y >= height)
    {
        do
        {
            y = y - height;
        }while(y >= height);
    }
    else if(y < 0)
    {	
        do
        {
            y = y + height;
        }while(y < 0);
    }

    return array[width * y + x];
}

void convolveKernelAndImage(const ConvolutionKernel &kernel, double imageData[], double *newImageData, int i, int j, int imageWidth, int imageHeight)
{
    double newValue = 0;

    int kRow = 0, kCol = 0;

    int y = 0, x = 0;

    for(y = i - kernel.center; y <= i + kernel.center; ++y)
    {
        kCol = 0;
        for(x = j - kernel.center; x <= j + kernel.center; ++x)
        {
            newValue += sample(imageData, x, y, imageWidth, imageHeight) * kernel.data[kernel.size * kRow + kCol];
            ++kCol;
        }
        ++kRow;
    }

    newImageData[imageWidth * i + j] = newValue;
}

void GaussianBlur_apply(const ConvolutionKernel &kernel, double imageData[], int imageWidth, int imageHeight)
{
    double *newImageData = (double*)malloc((imageWidth * imageHeight) * sizeof(double));

    int i = 0, j = 0;

    for(i = 0; i < imageHeight; ++i)
    {
        for(j = 0; j < imageWidth; ++j)
        {
            convolveKernelAndImage(kernel, imageData, newImageData, i, j, imageWidth, imageHeight);
        }
    }

    //Copy newImageData to imageData
    i = 0; j = 0;

    for(i = 0; i < imageHeight; ++i)
        for(j = 0; j < imageWidth; ++j)
            imageData[imageWidth * i + j] = newImageData[imageWidth * i + j];


    free(newImageData);
}

#endif