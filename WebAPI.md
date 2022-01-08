# Web API

- Slide 189- 203
- Lab 22
- Add the ability to search by course title using the following URL:
  - `/api/course?title=net`
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
