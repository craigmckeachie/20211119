# Solution Code

- [Socrates](https://github.com/craigmckeachie/Socrates)




# Web API

- Slide 189- 203
- Lab 22
- Add the ability to search by course title using the following URL:
   -  `/api/course?title=net`
- Test your API to verify it works using the REST Client extension in VS Code
  - [REST Client VS Code extension by Huachao Mao](https://marketplace.visualstudio.com/items?itemName=humao.rest-client)  
  - [API Testing](./rest-review.http)
- The solution Code is listed below:
    ```cs
    public IEnumerable<Course> GetByTitle(string title)
    {
        return context.GetAllCourses().Where(c => c.Title.Contains(title)).ToList();
    }
    ```

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

<!-- var url = '@Url.RouteUrl("DefaultApi", new { httproute = "", controller = "Course", title = "net")'; -->

## Documentation

- [jQuery Documentation](https://learn.jquery.com/about-jquery/how-jquery-works/)
- [jQuery Quick API Reference](https://oscarotero.com/jquery/)

## Commands

```js
var test = 'Army'
console.log(test)
$("a.yellow-button-on-dark-background").get(0)
$("a")
$("a").length
$("a.second-level-tagging").length
$("a").first().text("foo")
$("a[data-di-id='di-id-13cc3787-99e97e5']").get(0)
```


## Selectors

## Exercise 1
1. Visit [goarmy.com](https://www.goarmy.com/)
2. Open Chrome Devtools
3. Switch to the Console tab
4. Select the page title (h1) and log the text to the console
5. Select the page title (h1) and change the text
6. Select the "EXPLORE BENEFITS" button using it's CSS class and display the HTML
7. Find other interesting items to select on the page and change

## jQuery Object 
- [(Wrapped Element Set) methods](https://learn.jquery.com/using-jquery-core/jquery-object/)

### Exercise 2
1. Visit [goarmy.com](https://www.goarmy.com/)
2. Open Chrome Devtools
3. Switch to the Console tab
4. Use the [Quick API Reference](https://oscarotero.com/jquery/) `Manipulation` column to find methods to manipulate elements on the page in various ways.

## AJAX

### Exercise 3

0. Instructor will live code this and then students will work on the exercise.
1. Create a new Course controller action `Find` and a corresponding view (the view should use the empty template and have no model).
1.  Use jQuery's `.ajax({})` function to call the course API `GetByTitle` action we created earlier. 
1. Log the results to the console.
1. Display `Loading...` while the AJAX call is in flight and then hide it when the results are available.
1. Display the results using HTML.
1. Below is the finished code as reference
```cs

@{
    ViewBag.Title = "Find";
}

<h2>Find Course</h2>

<div class="row">
    <form class="col-md-12 form-inline">
        <div class="form-group">
            <input class="form-control" name="searchTerm" type="search" placeholder="Course Title" />
            <button type="submit" class="btn btn-primary">Search</button>
        </div>
    </form>
    
</div>
<div class="row" style="margin-top: 30px;">
    <div class="col-md-12">
        <div class=" list-group" id="searchResults">
        </div>
    </div>
</div>

@section Scripts{
    <script>
        $(function () {
            $("form").on("submit", function (event) {
                event.preventDefault();
                $("#searchResults").text("Loading...");
                var searchTerm = $("input[name='searchTerm']").val();

                var url = `/api/course?title=${searchTerm}`;
                $.ajax({
                    method: 'GET',
                    url: url,
                }).then(function (courses) {
                    console.log(courses);
                    let html = '';
                    courses.forEach(function (course) {
                        html += `<div class='list-group-item '>${course.Title}</div>`;
                    });
                    $("#searchResults").html(html);
                })

            })

        })
    </script>

}
```



<br>

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
1. Repository and Unit of Work  -->


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