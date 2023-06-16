
# InterlockedUtils
Provides utilities functions that can be used in addition to the built-in Interlocked class.

## Usage
Add the following to use this library:
```cs
using AG;
```

All methods are static and can be called as follow:
```cs
var value = 15;
InterlockedUtils.Max(ref value, 12) // Returns 15
InterlockedUtils.Min(ref value, 8) // Modifies value and returns 8 atomically
```
All functionality makes heavy used of the built-in Interlocked class.

## Methods
- Add
Add methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)
Note: The built-in Interlocked class only got Add for int, uint, long and ulong. You may want to use these instead unless you're doing it for the additional types implemented here.

- Substract
Substract methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)

- Multiply
Multiply methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)

- Divide
Divide methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)

- Modulo
Modulo methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)

- Min
Min methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)

- Max
Max methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)

- ShiftLeft
Max methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)

- ShiftRight
Max methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)

- Increment
Increment methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)
Note: The built-in Interlocked class only got Add for int, uint, long and ulong. You may want to use these instead unless you're doing it for the additional types implemented here.

- Decrement
Decrement methods for all supported types (int, uint, long, ulong, nint, nuint, float, double)
Note: The built-in Interlocked class only got Add for int, uint, long and ulong. You may want to use these instead unless you're doing it for the additional types implemented here.

- Update
Update methods for all supported types (int, uint, long, ulong, nint, nuint, float, double, object, T)
Update allows you to perform an arbitriary operation on a value. The operation may run multiple times until succeeded

## Disclaimer
This class is not meant as a replacement for the built-in Interlocked class, but rather provide additional functionality based off it. All functionality makes heavy use of Interlocked.CompareExchange

## License
MIT

## Credits
Azure Gem