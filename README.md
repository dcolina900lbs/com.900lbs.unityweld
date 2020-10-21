# Unity Weld

*[MVVM-style](https://msdn.microsoft.com/en-us/library/hh848246.aspx) data-binding system for Unity.*

Unity Weld is a library that enables two-way data binding between Unity UI widgets and game/business logic code. This reduces boiler-plate code that would otherwise be necessary for things like updating the UI when a property changes, removes the need for messy links between objects in the scene that can be broken easily, and allows easier unit testing of code by providing a layer of abstraction between the UI and your core logic code.


## Installation

Open the `manifest.json` file in the `Packages` folder of your project and add the following to the `"dependencies"` section:

```JSON
"com.900lbs.unityweld" : "https://github.com/dcolina900lbs/com.900lbs.unityweld.git#upm"
```

## Getting started

Import the **Core Samples** into your project through the Unity Package Manager UI. These examples showcase the core features of the toolset.

## Resources

A series of articles on Unity Weld has been published on [What Could Possibly Go Wrong](http://www.what-could-possibly-go-wrong.com/bringing-mvvm-to-unity-part-1-about-mvvm-and-unity-weld).
