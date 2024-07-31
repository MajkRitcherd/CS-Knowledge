# Data types

Data type is a classification that **specifies** the type of data that a variable or expression can hold in a programming language. Defines operations that can be performed on the data, the way the data is stored, and the possible value the data can take.

Data types are **essential** in programming language because they help ensure **data integrity**, **optimize memory usage**, and enable proper operation of functions and methods.

Divided into 3 categories:
- **Primitive data types** (Basic type provided by programming language, e.g. bool, char, integer, float, ...)
- **Composite data types** (Composed of multiple primitive types, e.g. arrays, structures, classes)
- **Abstract data types** (Defined by behaviour rather than implementation, e.g. Stacks, queues, linked lists)





# Content

- [Bool](#bool)
- [Char](#char)
- [Integer](#integer)
- [Floag](#float)

# Bool

Typically represents **'true'** or **'false'**, but its memory allocation can vary. Generally, it's stored in a **single byte (8 bits)** in most systems, because CPU cannot address anything smaller than this. But some languages or implementations may optimize this to a **single bit** withing larger structures

Internally, **'true'** is often represented by the value **'1'**, **'false'** by the value **'0'**.

```
    if (true) {
        Print("Hello from true branch")
    }
    else {
        Print("Hello from false branch");
    }
```
The code block bellow will enter first branch and display to the console ```Hello from true branch```.

### Use cases

Bool values are commonly used as **flags** to indicate the state of an object or the occurrence of an event, or in **decision-making processes** in algorithms and functions to determine which path to take based on conditions. They are also often used in **conditional statements** ('if', 'else', 'while', 'for') to **control the flow of execution** based on certain conditions.

### Truthiness x Falsiness

In some languages, values other than **'true'** can evaluate to **'true'** in a boolean context. For example, non-zero numbers, non-empty strings and non-empty lists are considered as **'true'** in Python and this is called **Truthiness**.
On the other hand, there's **Falsiness** which states that values other than **'false'** can evaluate to **'false'**. In Python, '0', empty strings and empty lists are considered as **'false'**.





# Char
Another fundamental (primitive) data type, typically used to represent a single character. In most languages, **char** is a fixed-size data type, usually occupying **one byte** (8 bits) of memory. Some languages allocates for the **char** 2 bytes (16-bits) of memory. 

### 1-Byte x 2-Byte
With 1 byte allocation, we can store 256 values, ranging from -127 to 128. If we were using **unsigned char**, then the range would be from 0 to 255.
2 bytes allocation is used to be able to store in a char other characters than characters from Extended ASCII table. Using the 2 bytes memory allocation, we are able to store Unicode character (limited to Basic Multilingual Plane) into the variable and we can save up to 65 536 values depending whether the **char** is unsigned (range: 0 up to 65 536) or signed (-32 767 up to 32 768).

### Operations

We can perform various operations on **char** data types, such as comparison, arithmetic operations (e.g. increment **char** to get next character, summing 2 characters, subtracting, ...) and seamlessly cast between **char**s and **integer**s.





# Integer

# Float