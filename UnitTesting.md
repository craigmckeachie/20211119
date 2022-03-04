- [Walkthrough: Using TDD with ASP.NET MVC](<https://docs.microsoft.com/en-us/previous-versions/aspnet/ff847525(v=vs.100)?redirectedfrom=MSDN>)
- [Automapper Testing](https://docs.automapper.org/en/latest/Getting-started.html#how-do-i-test-my-mappings)
- [Implementing and Testing Repository Pattern Using Entity Framework](https://rubikscode.net/2018/04/16/implementing-and-testing-repository-pattern-using-entity-framework/)


.CreateMap<Source, Dest>()
    .ForMember(source => source.Date, opt => opt.Ignore());