# Bubble Sort Study – C# Implementation

This repository contains a simple implementation of the **Bubble Sort** algorithm using C#. It was created for study and experimentation purposes to understand how the algorithm works in practice.

## Description

The goal of this project is to demonstrate the **Bubble Sort** algorithm by sorting an array of integers in ascending order.

## What is Bubble Sort?

Bubble Sort is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. The pass through the list is repeated until the list is sorted.

Although not efficient for large datasets, Bubble Sort is useful for educational purposes due to its straightforward approach.

## Code Overview

```csharp
int[] input = { 4, 3, 7, 9, 1, 14, 47, 84, 14, 94 };
```

An unsorted array of integers is defined.

```csharp
for (int i = 1; i < input.Length - 1; i++)
{
    for (int j = 0; j < input.Length - i; j++)
    {
        if (input[j] > input[j + 1])
        {
            int temp = input[j];
            input[j] = input[j + 1];
            input[j + 1] = temp;
        }
    }
}
```

### Explanation:

- The **outer loop** controls the number of passes.
- The **inner loop** compares each pair of adjacent elements and swaps them if they are in the wrong order.
- This way, the largest unsorted value "bubbles up" to its correct position with each pass.

### Note:
There is a minor off-by-one mistake in the outer loop:
```csharp
for (int i = 1; i < input.Length - 1; i++) 
```
should ideally be:
```csharp
for (int i = 0; i < input.Length - 1; i++)
```
so that all necessary passes are performed.

```csharp
Console.WriteLine(input);
```

This line attempts to print the array, but it will display the type name instead of the array contents. It should be replaced with:

```csharp
Console.WriteLine(string.Join(", ", input));
```

to properly display the sorted result.

## Output (after fix)

```
1, 3, 4, 7, 9, 14, 14, 47, 84, 94
```

## Purpose

This implementation is used to:

- Understand how Bubble Sort works step-by-step
- Experiment with array manipulation and nested loops in C#
- Analyze the algorithm’s behavior and limitations

## Learn More

- [Bubble Sort on Wikipedia](https://en.wikipedia.org/wiki/Bubble_sort)
- [Time Complexity: O(n²)] – inefficient for large arrays
- [Stable Sort] – maintains the relative order of equal elements
