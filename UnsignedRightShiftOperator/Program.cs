﻿using System.Diagnostics.Metrics;

int n = -32;
Console.WriteLine($"Before shift: bin = {Convert.ToString(n, 2),32}, dec = {n}");

int a = n >> 2;
Console.WriteLine($"After     >>: bin = {Convert.ToString(a, 2),32}, dec = {a}");

int b = n >>> 2;
Console.WriteLine($"After    >>>: bin = {Convert.ToString(b, 2),32}, dec = {b}");

// Output: Bitwise and shift operators.
// Before shift: bin = 11111111111111111111111111100000, dec = -32
// After     >>: bin = 11111111111111111111111111111000, dec = -8
// After    >>>: bin =   111111111111111111111111111000, dec = 1073741816


