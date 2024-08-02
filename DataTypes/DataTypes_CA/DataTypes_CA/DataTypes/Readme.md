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
- [Short](#short)
- [Integer](#integer)
- [Long](#long)
- [Float](#float)
- [Double](#double)

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
2 bytes allocation is used to be able to store in a char other characters than characters from Extended ASCII table. Using the 2 bytes memory allocation, we are able to store Unicode character (limited to Basic Multilingual Plane) into the variable and we can save up to 65,536 values depending whether the **char** is unsigned (range: 0 up to 65,536) or signed (-32,767 up to 32,768).

### Operations

We can perform various operations on **char** data types, such as comparison, arithmetic operations (e.g. increment **char** to get next character, summing 2 characters, subtracting, ...) and seamlessly cast between **char**s and **integer**s.





# Short
Next fundamental (primitive) data type used to represent small integer values. The **short** data type is typically smaller than the **int** data type.
It is guaranteed to be at least 2 Bytes (16-bits) in size, but the exact size can vary depending on the platform and compiler.

### Representation
The **short** data type can be either signed or unsiged, as some other data types. Range of a signed **short** is from -32,768 up to 32,767 (the range is due to its 16-bit size, where 1 bit is used for the sign) and range of an unsigned **short** is from 0 to 65,535.

### Operations
We can perform various operations on **short** data types, such as arithmetic, bitwise, comparison operations. We can cast it to another data type as well either implicitly or explicitly. Implicit casting means that we are casting the data type to a data type which is bigger in size, e.g. short (16-bit) -> int (32-bit), char (8-bit) -> short (16-bit). Explicit casting means the opposite, casting from bigger to smaller one. Overflow may occur, so be careful, e.g. int (32-bit) -> short (16-bit), short (16-bit) -> char (8-bit).





# Integer
One of the most commonly used data type for numerical operations. The data type can precisely represent any whole number within its range depending on the type of an **int** data type. 

### Representation
By default, the **int** has 4 Bytes (32-bits), where the most significant bit represents the sign (0 for positive number, 1 for negative number). **Int** can have different representations, for example **Int64** has 8 Bytes (64-bits) or we can have smaller ones **Int16**, which has 2 Bytes (16-bits).
The default **Int**, the one with 4 Bytes, has range going from -2,147,483,648 to 2,147,483,647 for signed **Int** and range from 0 to 4,294,967,295 in case of unsigned **Int**.

### Operations
We can perform the same operations as on data type **short** (arithmetic, bitwise, comparison and casting to another data types). Integer arithmetic is typically faster than floating-point arithmetic on most processors, making **Int** a good choise for performace-critical code.





# Long
Another fundamental data type which is being used when **Int** data type does not provide a sufficient range. Again, the **Long** can hold only whole number within its range.

### Representation
The **Long** has 8 Bytes (64-bits), where the most significant bit represents the sign (0 for positive number, 1 for negative number). The range of a **Long** data type is from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 in case of signed **Long** or from 0 to 18,446,744,073,709,551,615 if unsigned **Long** is used.

### Operations
We can perform the same operations as on data types mentioned earlier (**short**, **Int**), meaning arithmetic, bitwise, comparison and casting operations.





# Float
**Float** data type is used to represent a single-precision floating-point numbers. It follows the IEE 754 standard for floating-point arithmetic, which defines how floating-point numbers are stored and calculated. The size of a **float** is 4 Bytes (32-bits) and has a precision of 6-9 significant decimal digits and the range is approximately from ±1.5 x $10^{-45}$ up to ±3.4 x $10^{38}$.

### IEE 754 Standard
Defines the representation and behaviour of floating-point numbers, ensuring consistency across different computing system.

#### Sturecture of a **Float**
Value = $(−1)^{sign}$ × 1.mantissa × $2^{exponent−127}$
- Sign Bit (1 bit): Determines the sign of the number (0 is positive, 1 is negative)
- Exponent (8 bits): Stored with a bias of 127, allowing for a range of positive and negative exponents
- Mantissa (23 bits): Represents the significant digits of the number, with an implicit leading 1.

### Special values
1. Positive and Negative Infinity: Result form operations like division by zero.
2. NaN (Not a Number): Represents an undefined or unrepresentable value, such as the result of 0/0.
3. Zero: Both positive zero (+0) and negative zero (-0).

Due to the limited number of bits for the mantissa, **float** numbers have limited precision. This can lead to rounding errors in calculcations, especially when dealing with very small or very large numbers. Other then that, we can use arithmetic, bitwise, comparison and casting operations. **Float** is preferred when performance is crucial and precision is less critical. Also **float**s are generally faster than the next data type called **double**.





# Double
**Double** data type is used to represent a double-precision floating-point numbers. It follows the IEE 754 standard as the **float** does.The size of a **double** is 8 Bytes (64-bits) and has a precision of approximately ±5.0 x $10^{-324}$ to ±1.7 x $10^{308}$.

### Strucutre of a **Double**
The structure is the same as for the **float** data type.
Value = $(−1)^{sign}$ × 1.mantissa × $2^{exponent−127}$, where
- Sign Bit (1 bit): Determines the sign of the number (0 is positive, 1 is negative)
- Exponent (11 bits): Encoded using a biased representation
- Mantissa (52 bits): Represents the significant digits of the number, with an implicit leading 1.

Special values of a **double** are the same as for the **float**. Due to the larger number of bits for the mantissa, **double** numbers have higher precision than **float**, which reduces rounding errors in calculations, making **double** suitable for applications requiring high precision as in finances. Again, we can use all operations as mentioned for the type **float**