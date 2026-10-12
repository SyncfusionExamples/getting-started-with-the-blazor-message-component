# Getting Started with the Blazor Message Component

## Overview

This sample demonstrates the Syncfusion [Blazor Message](https://www.syncfusion.com/blazor-components/blazor-message) component in a Blazor WebAssembly application. The project shows how to present contextual messages with different visual variants, display or hide severity and close icons, customize appearance, and render message content using templates.

The sample provides a practical reference for displaying informational, success, warning, and error messages in Blazor applications. It also illustrates common customization patterns that help create a consistent user experience across application workflows.

## Key Features

- Displays a Syncfusion [Blazor Message](https://www.syncfusion.com/blazor-components/blazor-message) component when the ls outside the valid range of 18 to 60.
- Uses Razor conditional rendering (`@if`) to dynamically show validation feedback based on user input.
- Configures the `Variant` property with `MessageVariant.Outlined` to render the message using an outlined visual style.
- Sets the `Severity` property to `MessageSeverity.Warning` to indicate validation-related warnings.
- Uses the `ContentAlignment` property with `HorizontalAlign.Center` to center the message content.
- Enables the `ShowIcon` property to display the built-in warning severity icon.
- Enables the `ShowCloseIcon` property to provide a standard message close button.
- Controls message visibility through the `Visible` property bound to the `isMessageVisible` field.
- Demonstrates two-way input binding using `@bind-value` to monitor age changes in real time.
- Uses a Syncfusion `SfButton` component to perform a custom dismiss action.
- Handles the button `@onclick` event through the `dismissClick()` method to hide the message programmatically.
- Applies custom CSS styling to the `.e-message` class to control the displayed message width.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone this repository.
2. Open `MyBlazorApp.sln`.
3. Restore NuGet packages.
4. Ensure `MyBlazorApp` is selected as the startup project.
5. Build the solution.
6. Press `Ctrl+F5` to run the application.

**Visual Studio Code**

1. Clone this repository.
2. Open the repository folder in Visual Studio Code.
3. Navigate to the project directory.

```bash
cd MyBlazorApp
dotnet restore
dotnet run
```

4. Open the URL displayed in the terminal after the application starts.

## Project Structure

`Pages/Index.razor` - Primary sample page that accepts age input, validates the entered value, and conditionally displays the Syncfusion Message component.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official Spinner documentation: https://blazor.syncfusion.com/documentation/message/getting-started

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.