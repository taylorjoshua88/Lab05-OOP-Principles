# Zoo

**Author**: Joshua Taylor
**Version**: 1.0.0

## Overview

Zoo is an application made to demonstrate the four pillars of object
oriented design -- Inheritance, Encapsulation, Polymorphism, and
Abstraction. The actual operation of the application is a simple
series of writing to the console various properties and methods
of classes up and down the class hierarchy emulating a tour guide giving
a tour of all of the zoo's animals to guests.

## Getting Started

Zoo targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can
be downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Zoo
    dotnet build
    dotnet run

Additionally, users can build, run, and perform unit testing using Visual
Studio 2017 or greater by opening the solution file at the root of this
repository.

## Example

#### Starting a New Game ####
![Birds Screenshot](/assets/birdsScreenshot.JPG)
#### Taking a Turn ####
![Fish Screenshot](/assets/fishScreenshot.JPG)
#### Victory ####
![Mammals Screenshot](/assets/mammalsScreenshot.JPG)

## Architecture

Zoo is composed of numerous classes representing individual species of
animals. Each of these are derived from base classes which provide common
functionality across the taxonomy of the zoo's various fauna. An example
of this is the Eagle class which is a concrete class that inherits from
the Raptor abstract class which inherits from the Flying abstract class
which inherits from the Bird class which inherits from the master base
class for all animals in the zoo, Animal.

### Class Hierarchy

The following is a graphical representation of the class hierarchy for all
derived animal classes and their bases, ultimately leading to the master
base class, Animal. Each class in the following diagram include the access
modifiers (encapsulation), abstractions (abstraction / polymorphism), and
inheritance represented by arrows (inheritance).

![Class Hierarchy Diagram](/assets/zooClasses.JPG)

### Data Model

All data is stored in memory on the heap by instantiating classes using the
*new* keyword. No data persistence is supported by this application.

### Command Line Interface (CLI)

Zoo's interface is a simple console-based command line interface. Text is
written to the console emulating a tour guide giving a tour of all the
animals in the zoo followed by prompts for the user to press a key.

## Change Log

* 3.26.2018 [Joshua Taylor](mailto:taylor.joshua88@gmail.com) - Initial
release. All tests are passing.