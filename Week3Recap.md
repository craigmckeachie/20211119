# Week 3 Recap

1. Created database diagram of DD200 related tables:

- Eflipl_dd200_form_creation.pdf

2. Attempted to unit test recent bug fix where unit cost was getting set to null but did not succeed.
3. Fixed bug related to ?
   - solution was to append FLIPL_ID when doing HTTP post
4. Documented Eflipl_dd200_form_creation workflow.

- CreatePDFWorkflow.docx

5. Worked on profiling the application.

- [PerfTips: Performance Information at-a-glance while Debugging with Visual Studio](https://devblogs.microsoft.com/devops/perftips-performance-information-at-a-glance-while-debugging-with-visual-studio/)
- [Using Perf Tips in Visual Studio](https://docs.microsoft.com/en-us/visualstudio/profiling/perftips?view=vs-2022)
- [dotTrace: tried ran into permissions issues](https://www.jetbrains.com/profiler/?source=google&medium=cpc&campaign=12509621735&gclid=CjwKCAiAjoeRBhAJEiwAYY3nDCYLX_i21sMYk3GNys4CqJoGG8Yv68DDauySCY-IxqD5PDM6Y003hxoCmcMQAvD_BwE)
- [Ants Profile (still need to try)](https://www.red-gate.com/products/dotnet-development/ants-performance-profiler/)

## Research

- [Threads in Azure App Service](https://stackoverflow.com/questions/66767153/threadcount-metric-in-azureappservice)
- [Consider using Web Job or Azure Function](https://docs.microsoft.com/en-us/azure/architecture/best-practices/background-jobs#azure-web-apps-and-webjobs)
- [Cross-context transaction](https://docs.microsoft.com/en-us/ef/core/saving/transactions#cross-context-transaction)

## Entity Framework

[Working with Transactions](https://docs.microsoft.com/en-us/ef/ef6/saving/transactions?redirectedfrom=MSDN)

### Designer

An Entity Data Model Diagram is just a visual display of an EDMX file. In order to get such a diagram from a Code-First model you must create an EDMX file from it:

```C#
using System.Data.Entity.Infrastructure; // namespace for the EdmxWriter class

using (var ctx = new MyContext())
{
    using (var writer = new XmlTextWriter(@"c:\Model.edmx", Encoding.Default))
    {
        EdmxWriter.WriteEdmx(ctx, writer);
    }
}
```

This code creates a file Model.edmx that you can open in Visual Studio. It will display the model diagram. The EDMX file is a snapshot of your current Code-First model. When you change the model in code you must create a new EDMX file to reflect those changes in the diagram.

- [Source](https://stackoverflow.com/a/18665335/48175)
