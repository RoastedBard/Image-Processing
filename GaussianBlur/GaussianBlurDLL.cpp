#include <stdio.h>

#include "ConvolutionKernel.h"
#include "GaussianBlur.h"

extern "C"
{
    __declspec(dllexport) void GaussianBlur(double imageData[], int convolutionKernelSize, int convolutionKernelDeviation, int imageWidth, int imageHeight);
}

void GaussianBlur(double imageData[], int convolutionKernelSize, int convolutionKernelDeviation, int imageWidth, int imageHeight)
{
    ConvolutionKernel kernel;

    ConvolutionKernel_initialize(kernel, convolutionKernelSize, convolutionKernelDeviation);
    ConvolutionKernel_generate(kernel);

    GaussianBlur_apply(kernel, imageData, imageWidth, imageHeight);

    ConvolutionKernel_destroy(kernel);
}