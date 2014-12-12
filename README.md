# MaryPopin for Xamarin iOS
This is a Xamarin C# binding on [MaryPopin](https://github.com/Backelite/MaryPopin),
an iOS library for presenting modal like controllers.

This project contains:

- A git submodule to the version of MaryPopin used to create the binding
- A Xcode project to build MaryPopin as a static library
- A Xamarin project to build the binding

The latest dll is directly available [here](Binding/MaryPopin/bin/Release/MaryPopin.dll).

It is 32-bits only for the moment but will be 64-bits as soon as Xamarin releases its Unified library in stable stage.

## Usage
Include the dll in your Xamarin iOS project, the Api is available under the MaryPopin namespace.

## Feature request, bug reports
Please report to the [MaryPopin](https://github.com/Backelite/MaryPopin) project if related to the library itself, to this project if related to the binding.

## Documentation
See [MaryPopin](https://github.com/Backelite/MaryPopin).

## Contributing

Contributions for bug fixing or improvements are welcomed. Feel free to submit a pull request.

## License
MaryPopin for Xamarin iOS is available under the MIT license. See the LICENSE file for more info.
