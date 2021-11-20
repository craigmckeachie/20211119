# Rest APIs


# Web API

- Slide 189- 203
- Lab 22

# jQuery

<!-- ## Slides
- [jQuery Intro](.\jQuery\01-jQuery.pdf)
- [jQuery Object](.\jQuery\02-jQueryObject.pdf)
- [jQuery Events](.\jQuery\03-jQueryEvents.pdf)
- [jQuery Effects](.\jQuery\04-jQueryEffects.pdf)
- [jQuery AJAX](.\jQuery\05-jQueryAJAX.pdf)
- [jQuery Plugins](.\jQuery\06-jQueryPlugins.pdf)



## Code
- [jQuery Code Examples](https://wnow.blob.core.windows.net/collateral/Prosise-jQuery-Code.zip) -->

## Documentation

[jQuery Documentation](https://learn.jquery.com/about-jquery/how-jquery-works/)

## Exercises

### Selectors
1. Visit [goarmy.com](https://www.goarmy.com/)
2. Open Chrome Devtools
3. Switch to the Console tab
4. Select the page title (h1) and log the text to the console
5. Select the page title (h1) and change the text
6. Select the "EXPLORE BENEFITS" button using it's CSS class and display the HTML
7. Find other interesting items to select on the page and change

### jQuery Object 
- (Wrapped Element Set) methods

### AJAX

<br>

# Entity Framework

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
1. Repository and Unit of Work  -->


### Solution Code

## Reference: 
- [Code First from Existing Database](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database)
- [Query Syntax vs Method Syntax](https://stackoverflow.com/questions/8037677/linq-query-syntax-vs-method-chains-lambda)
- [Do I have to Call Dispose on DBContext](https://blog.jongallant.com/2012/10/do-i-have-to-call-dispose-on-dbcontext/)
- [Querying Related Data](https://docs.microsoft.com/en-us/ef/ef6/querying/related-data)