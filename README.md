# MVVM samples for the Universal Windows Platform

Sample applications that show how to apply the **Model-View-ViewModel (MVVM)** pattern
in Universal Windows Platform (UWP) apps for Windows 10, using several of the most
popular MVVM toolkits side by side so you can compare the approaches.

> **Historical sample.** These projects target UWP on Windows 10. The patterns still
> apply to modern XAML apps, but newer projects should consider **WinUI 3 / Windows App
> SDK** and the **CommunityToolkit.Mvvm** library.

## What's included

Each top-level folder is a self-contained solution focused on one MVVM framework:

| Folder | Framework |
| --- | --- |
| `Caliburn Micro` | MVVM with Caliburn.Micro (basic and advanced scenarios, services, RSS feed example). |
| Additional folders | Equivalent samples built with other MVVM toolkits (e.g. MVVM Light, Prism) and plain hand-rolled MVVM. |

Typical concepts covered: data binding, commands, navigation, dependency injection,
view/view-model wiring and consuming services from a view model.

## Prerequisites

- Windows 10
- Visual Studio 2015 / 2017 with the **Universal Windows Platform development** workload
- Windows 10 SDK

## Getting started

1. Clone the repository.
2. Open the `.sln` inside the framework folder you are interested in.
3. Restore NuGet packages and run (F5).

## License

Released under the [MIT License](LICENSE).
