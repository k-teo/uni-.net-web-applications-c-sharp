A description of the repository
------------------------------

A repository contains tasks prepared for university classes called .net Web Applications.

List 3
--------------------

### Tasks:
1. Read the dimensions of the two-dimensional array n and m, then fill it with random
natural numbers. Print the contents of the matrix with lines. Efficiently reverse the
order of the rows in this array (the first row is to be the last one, the second one is
the prelast, etc.), show the modified array on the screen.
a. Use a two-dimensional array type
b. Use an array of arrays type.
2. Create a tuple consisting of data from the user: name, surname, age, salary. Call the
function with this tuple, as the parameter. Show 3 ways to use this tuple to list the
information you provided.
3. Create a variable named class, write a value for it and print it on the screen.
4. Present the use of 5 different selected methods from the System.Arrays module.
5. Can task 2 be done with the anonymous type in the same simple way?

### Terms used in tasks:
- if...else statment
- for loop
- writing/reading from console
- two-dimentional arrays
- reverse of array
- tuple
- anonymous type

List 4
--------------------

### Tasks:
1. Write the GetFromConsoleXY method, which will receive two comment lines in
its parameters. The method will print the first line and read an integer. Prints the
second line of the comment and reads the second integer.
a. First realisation - These two numbers are returned as a pair (tuple)
b. The second implementation - a void method that returns two numbers in the
parameters
2. Write the DrawCard method "drawing" a business card. The method receives in the
parameters the first line of the business card, the second line, the border mark, the
border width, the minimum width of the entire business card. Apart from the first
parameter, the others are optional (choose your own default values). Demonstrate
various method calls, including using named parameters. A business card is a
rectangular frame with centered text, e.g. for a data set
DrawCard („Ryszard”,”Rys”,”X”, 2, 20) "draws":

<pre>
XXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXX
XX     Ryszard    XX
XX      Rys       XX
XXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXX
</pre>

3. Create the CountMyTypes method, in which parameters you can specify any
sequence of elements separated by commas, and this method will count how many
even integers, positive real numbers, strings of at least 5 characters and elements
other than the above mentioned types can be returned by four values as you want.
Use switch/case statement.
4. Supplement the above tasks with directives that allow you to easily start the
application so that you can see more information on the execution of its operation on
the console (eg in task 3 to inform which type has just been detected).
### Terms used in tasks:
- out paramiter
- ?: operator
- params
- preprocessor directives
- switch statment
- when in switch statment

List 5
--------------------

### Tasks:
1. Write the MixedNumber class to store a mixed number that will store the integer part, the
numerator and the denominator in three properties (numerator and denominator always
positive). For the integer part, the automatic property should be used, for the numerator and
denominator, the property will write the absolute value if a negative value is given. The value
of the fraction should always be simplified to the lowest possible denominator, which is
always greater than the numerator (also after changing the denominator or numerator).
Propose a minimum of 3 constructors (the part should be invoked by another constructor).
Reload operator '+'. The class is to have a property to get a fraction as a double number.
Implement your own ToString() method for this class. The class is also to count the
number of times (globally) the object representation had to be modified in order to modify it
to the form consistent with the assumption. It also has, of course, the ability to retrieve the
value of this counter.
2. Write a function that extends the string class with the possibility of replacing the string in
such a way that even positions of the string will be converted to uppercase, and odd items to
lowercase. Items which are not letters are to be replaced with a period '.'.

### Terms used in tasks:
- keyword: this
- ascii code
- getters and setters
- overiding ToString()
- extending class String
- reloading opertor '+'
- using variable globally
- using multiple constructors


List 6
--------------------

### Tasks:
1. Write the classes related to the inheritance relationship: Vehicle, MotorVehicle,
Bicycle, Car, Truck. The classes are to be used to remember vehicles on the auction
site. In each class, create a minimum of 2 fields/properties specific to it (e.g. brand, model,
load capacity, etc.) as well as at least one method. Designate an abstract class. Each class
should have its implementation of the ToString() method. Create an array (possibly a
collection) of abstract class objects. Write methods that, using the is or as operators, will
calculate the total load capacity of vehicles, provided that the vehicle has such a property as
load capacity (i.e. it is of the appropriate class).
2. Write an IFigure interface with the method: void moveTo (double x, double
y) and the IHasInterior interface with the property to set and download the interior
color. Create classes, one of which implements one and the other of both interfaces. Use an
implicit implementation for the first interface, and an explicit implementation for the second.
Create an array/collection of objects of the object class. Create a method that will receive
such an array / collection and print their color for objects that implement the
IHasInterior interface, and the text "no color" for the rest. The color may be of type
string.
### Terms used in tasks:
- abstract class
- interface
- inheritance
- polymorphism
- implicit/explicit implementation
- is operator
- base
