# Averager
UWP Runtime Component (class that works with C#, JavaScript and C++) which calculates the average for you extremely easily.


## How To Start Using This:
Open the Nuget Package Manager console and enter this command: 

`Install-Package Averager.ColinKiama`

or...
In a a Universal Windows Project, go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution then on the "Browse" section, search for "Averager.ColinKiama" then, you can install the package for each project you want to use in your current solution.

## Tutorial:
There are two ways to use this:

First method:
```
// Create a list/arrary and enter it as the argument
int[] numbers = {1,2,3);
AverageCalculator.GetAverage(numbers); // returns 2;
```

Second Method: 
```
// Manually list any number of arguments yourself
AverageCalculator.GetAverage(1,2,3); // returns 2;
```
