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

### Object-Oriented Programming (OOP) Principals

#### Inheritance ####
Inheritance is the ability for classes to inherit methods, properties,
and fields from another class. The class which inherits these things is
called a derived class, and the class that is being inherited is a
base class. Inheritance allows us to reduce the amount of redundancy in
our code, enforce hierarchies of classes, and allow for modularity when
combined with the other principals of object oriented programming.

#### Encapsulation ####
Encapsulation is the ability for classes to control where and how its
methods, properties, and fields can be accessed. Some classes represent
state in a way that should not be accessed by end users. Examples of this
include file I/O, cryptography, and complex, stateful data structures.
In these cases, a class can restrict users from modifying its state in
unexpected ways by exposing a controlled, safe API. This API, being a
part of the class itself (or along an inheritance hierarchy) can manipulate
the class's state as it was intended by the class's and overall
architecture's designers. An added benefit to encapsulation is its ability
to hide complexity from users by only allowing the relevant subset of
methods and properties needed to interact with a particular class.

#### Polymorphism

Polymorphism is the ability of methods and properties to take on multiple
forms based on the context of operation and/or state. A base class can
declare abstractions to methods and properties that can be overridden by
derived classes which modify their behavior and/or default state. The end
user does not need to concern him or herself with as many details of this
polymorphic implementation but can instead rely on objects' classes to
provide relevancy to the context in which those objects are being used.
_Polymorphism enables code modularity and extensibility through
substitution_ and prevents redundant methods from having to be written to account for miniscule variations between classes.

#### Abstraction

Abstraction is the ability in object-oriented programming to provide
partial definitions of methods and properties which can be defined elsewhere
by a derived class. A base class can define the types of behaviors that are
to be expected for derived classes to have without forcing pre-defined
behavior. This can be done by simply delineating the signature for a method
or property, or it can be done by providing a default implementation which
can then be overridden for more specific behavior by a derived class. The
former is known in C# as _abstract_ methods and properties, and these can
only be declared within abstract classes which cannot be instantiated.
These must be implemented by the first non-abstract, concrete class within
an inheritance hierarchy. The latter is provided via the _virtual_ keyword in C#, and these can be declared in abstract *or* non-abstract, concrete
classes. 

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

#### Birds ####
![Birds Screenshot](/assets/birdsScreenshot.JPG)
#### Fish ####
![Fish Screenshot](/assets/fishScreenshot.JPG)
#### Mammals ####
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