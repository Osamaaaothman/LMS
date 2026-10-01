# LMS — Library Management System

A C# (.NET 9) console application modelling a library: books, members (students and teachers), borrowing transactions, and fine calculation.

## Domain model

- `Book`, `Library`, `Transaction`
- `Member` with `StudentMember` and `TeacherMember` specializations
- `IFineCalculator` abstraction for fine rules

## Run

```bash
dotnet run --project LMS
```

## Author

[Osama Othman](https://github.com/Osamaaaothman)
