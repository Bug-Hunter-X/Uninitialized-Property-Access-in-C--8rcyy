# Uninitialized Property Access in C#

This repository demonstrates a common, yet easily missed, error in C#: accessing a property before it has been explicitly initialized.

## The Problem

In C#, class properties have default values if not initialized.  However, relying on these default values can lead to unexpected behavior and make debugging difficult.  The example shows how a property might be read before the code has a chance to set a meaningful value, leading to using the property's default value rather than the value it is expected to hold.

## Solution

The solution involves explicitly initializing the property in the constructor or before its first use, ensuring a consistent and predictable starting state.

## How to Run

1. Clone this repository.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Build and run the `UninitializedProperty.cs` file to see the unexpected behavior.
4. Then run the `UninitializedPropertySolution.cs` file to see the corrected version.
