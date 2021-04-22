#pragma once

#ifdef BUILD_MY_DLL
#define SHARED_LIB __declspec(dllexport)
#else
#define SHARED_LIB __declspec(dllimport)
#endif

extern "C" SHARED_LIB void bubleSort(int arr[], int n);
extern "C" SHARED_LIB void quickSort(int arr[], int n, int high);
extern "C" SHARED_LIB void shellSort(int arr[], int n);
extern "C" SHARED_LIB void heapSort(int arr[], int n);
extern "C" SHARED_LIB void insertionSort(int arr[], int n);