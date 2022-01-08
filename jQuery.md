# jQuery

## Documentation

- [jQuery Documentation](https://learn.jquery.com/about-jquery/how-jquery-works/)
- [jQuery Quick API Reference](https://oscarotero.com/jquery/)

## Commands

```js
var test = "Army";
console.log(test);
$("a.yellow-button-on-dark-background").get(0);
$("a");
$("a").length;
$("a.second-level-tagging").length;
$("a").first().text("foo");
$("a[data-di-id='di-id-13cc3787-99e97e5']").get(0);
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
1. Use jQuery's `.ajax({})` function to call the course API `GetByTitle` action we created earlier.
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

## Reference

- [jQuery Quick API Reference](https://oscarotero.com/jquery/)
- [Murach's JavaScript & jQuery](https://www.murach.com/shop/murach-s-javascript-and-jquery-4th-edition-detail)
- [jQuery in Action](https://www.manning.com/books/jquery-in-action-third-edition)
