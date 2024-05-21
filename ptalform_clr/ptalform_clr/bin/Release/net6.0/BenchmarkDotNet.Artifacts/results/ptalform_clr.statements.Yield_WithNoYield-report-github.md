```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2


```
| Method                         | Mean     | Error    | StdDev   | Gen0   | Allocated |
|------------------------------- |---------:|---------:|---------:|-------:|----------:|
| Run_GetAllWithYieldIEnumerable | 35.76 ns | 0.197 ns | 0.174 ns | 0.0032 |      40 B |
| Run_GetAllNoYield              | 23.36 ns | 0.492 ns | 1.110 ns | 0.0108 |     136 B |
