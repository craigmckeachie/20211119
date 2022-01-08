# Entity Framework

## Exercises

Use this as your database throughout these exercises.

#### `App.config`

```
connectionString="Data Source=(localdb)\MSSQLLocalDB;
```

### Setup

1. Create a new Console Project
2. Install Northwind Database using Scripts
   - [Download Scripts](https://jasontaylor.dev/wp-content/uploads/2017/03/NorthwindTraders.zip)
   - create db manually
   - open new query on db
   - open scripts in text editor (VS Code)
   - paste script into new query
3. Right click project > Add New Item > Entity Framework Model > name: NorthwindContext

### Query

1. Query the customer and output CompanyName
1. Enable Logging

   ```cs
   using System;
   using System.Linq;

   namespace NorthwindConsole1
   {
       class Program
       {
           static void Main(string[] args)
           {
               GetCustomers();
               Console.ReadLine();

           }

           static void GetCustomers()
           {
               using (var context = new NorthwindContext())
               {
                   context.Database.Log = Console.WriteLine;
                   var customers = context.Customers.ToList();
                   foreach(Customer customer in customers)
                   {
                       Console.WriteLine(customer.CompanyName);
                   }
               }
           }
       }
   }

   ```

1. Sort customers (use Query and Method Syntax)
1. Query customer by ID (use Query and Method Syntax)
   > Be sure the query is using parameters

### Mutations

- Do all the mutations to a Customer in a disconnected manner as you would in a web application

1. Insert
1. Update
1. Delete

### Related Data

1. Load Customer Orders both lazily (default) and eagerly (include)
<!-- 1. Migrations
1. Running SQL Commands
1. Repository and Unit of Work -->

### Solution Code

- [Entity Framework Solution Code](https://github.com/craigmckeachie/NorthwindConsole1)

## Reference:

- [Murach's JavaScript & jQuery](https://www.murach.com/shop/murach-s-javascript-and-jquery-4th-edition-detail)
- [Tutorial ASP.NET MVC with Entity Framework 6](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application)
- [Code First from Existing Database](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database)
- [Query Syntax vs Method Syntax](https://stackoverflow.com/questions/8037677/linq-query-syntax-vs-method-chains-lambda)
- [Do I have to Call Dispose on DBContext](https://blog.jongallant.com/2012/10/do-i-have-to-call-dispose-on-dbcontext/)
- [Querying Related Data](https://docs.microsoft.com/en-us/ef/ef6/querying/related-data)
- [Implementing the Repository and Unite of Work Patterns in ASP.NET MVC](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
- [](https://stackoverflow.com/questions/38996593/promise-equivalent-in-c-sharp#:~:text=6%20Answers&text=Task%20is%20a%20future,is%20a%20promise.)
- [](<https://docs.microsoft.com/en-us/previous-versions/aspnet/ff847525(v=vs.100)?redirectedfrom=MSDN>)