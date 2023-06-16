
using System;
using System.Threading;
using System.Diagnostics.CodeAnalysis;

namespace AG;

/// <summary>Additional utility methods complementing <see cref="Interlocked"/></summary>
[SuppressMessage("Minor Code Smell", "S4136", Justification = "Template Generated")]
public static class InterlockedUtils
{

	
	/// <summary>Changes <paramref name="value"/> into the minimum of <paramref name="min"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="min">Minimum value to compare into</param>
	/// <returns>Minimum of <paramref name="value"/> and <paramref name="min"/></returns>
	public static int Min(ref int value, int min)
	{
		while (true)
		{
		    var original = value;
			if (original <= min) return original;
			if (Interlocked.CompareExchange(ref value, min, original) == original) return min;
		}
	}
	
	/// <summary>Changes <paramref name="value"/> into the maximum of <paramref name="max"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="max">Maximum value to compare into</param>
	/// <returns>Maximum of <paramref name="value"/> and <paramref name="max"/></returns>
	public static int Max(ref int value, int max)
	{
		while (true)
		{
		    var original = value;
			if (original >= max) return original;
			if (Interlocked.CompareExchange(ref value, max, original) == original) return max;
		}
	}

	/// <summary>Multiplies <paramref name="value"/> with <paramref name="multiplier"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be multiplied with</param>
	/// <param name="multiplier">Value to multiply <paramref name="value"/> with</param>
	/// <returns>Multiplication result</returns>
	public static int Multiply(ref int value, int multiplier)
	{
		while (true)
		{
			var original = value;
			var result = original * multiplier;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Divides <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division result</returns>
	public static int Divide(ref int value, int divisor)
	{
		while (true)
		{
			var original = value;
			var result = original / divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Modulo <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division modulo result</returns>
	public static int Modulo(ref int value, int divisor)
	{
		while (true)
		{
			var original = value;
			var result = original % divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Adds <paramref name="value"/> with <paramref name="add"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be added with</param>
	/// <param name="add">Value to add <paramref name="value"/> with</param>
	/// <returns>Addition result</returns>
	public static int Add(ref int value, int add)
	{
		while (true)
		{
			var original = value;
			var result = original + add;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}
	
	/// <summary>Substracts <paramref name="value"/> with <paramref name="sub"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be substracted with</param>
	/// <param name="sub">Value to substract <paramref name="value"/> with</param>
	/// <returns>Substraction result</returns>
	public static int Substract(ref int value, int sub)
	{
		while (true)
		{
			var original = value;
			var result = original - sub;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Increments <paramref name="value"/> by 1</summary>
	/// <returns>Increment result</returns>
	public static int Increment(ref int value) => Add(ref value, 1);


	/// <summary>Decrements <paramref name="value"/> by 1</summary>
	/// <returns>Decrement result</returns>
	public static int Decrement(ref int value) => Substract(ref value, 1);

	
	/// <summary>Changes <paramref name="value"/> into the minimum of <paramref name="min"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="min">Minimum value to compare into</param>
	/// <returns>Minimum of <paramref name="value"/> and <paramref name="min"/></returns>
	public static uint Min(ref uint value, uint min)
	{
		while (true)
		{
		    var original = value;
			if (original <= min) return original;
			if (Interlocked.CompareExchange(ref value, min, original) == original) return min;
		}
	}
	
	/// <summary>Changes <paramref name="value"/> into the maximum of <paramref name="max"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="max">Maximum value to compare into</param>
	/// <returns>Maximum of <paramref name="value"/> and <paramref name="max"/></returns>
	public static uint Max(ref uint value, uint max)
	{
		while (true)
		{
		    var original = value;
			if (original >= max) return original;
			if (Interlocked.CompareExchange(ref value, max, original) == original) return max;
		}
	}

	/// <summary>Multiplies <paramref name="value"/> with <paramref name="multiplier"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be multiplied with</param>
	/// <param name="multiplier">Value to multiply <paramref name="value"/> with</param>
	/// <returns>Multiplication result</returns>
	public static uint Multiply(ref uint value, uint multiplier)
	{
		while (true)
		{
			var original = value;
			var result = original * multiplier;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Divides <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division result</returns>
	public static uint Divide(ref uint value, uint divisor)
	{
		while (true)
		{
			var original = value;
			var result = original / divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Modulo <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division modulo result</returns>
	public static uint Modulo(ref uint value, uint divisor)
	{
		while (true)
		{
			var original = value;
			var result = original % divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Adds <paramref name="value"/> with <paramref name="add"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be added with</param>
	/// <param name="add">Value to add <paramref name="value"/> with</param>
	/// <returns>Addition result</returns>
	public static uint Add(ref uint value, uint add)
	{
		while (true)
		{
			var original = value;
			var result = original + add;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}
	
	/// <summary>Substracts <paramref name="value"/> with <paramref name="sub"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be substracted with</param>
	/// <param name="sub">Value to substract <paramref name="value"/> with</param>
	/// <returns>Substraction result</returns>
	public static uint Substract(ref uint value, uint sub)
	{
		while (true)
		{
			var original = value;
			var result = original - sub;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Increments <paramref name="value"/> by 1</summary>
	/// <returns>Increment result</returns>
	public static uint Increment(ref uint value) => Add(ref value, 1);


	/// <summary>Decrements <paramref name="value"/> by 1</summary>
	/// <returns>Decrement result</returns>
	public static uint Decrement(ref uint value) => Substract(ref value, 1);

	
	/// <summary>Changes <paramref name="value"/> into the minimum of <paramref name="min"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="min">Minimum value to compare into</param>
	/// <returns>Minimum of <paramref name="value"/> and <paramref name="min"/></returns>
	public static long Min(ref long value, long min)
	{
		while (true)
		{
		    var original = value;
			if (original <= min) return original;
			if (Interlocked.CompareExchange(ref value, min, original) == original) return min;
		}
	}
	
	/// <summary>Changes <paramref name="value"/> into the maximum of <paramref name="max"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="max">Maximum value to compare into</param>
	/// <returns>Maximum of <paramref name="value"/> and <paramref name="max"/></returns>
	public static long Max(ref long value, long max)
	{
		while (true)
		{
		    var original = value;
			if (original >= max) return original;
			if (Interlocked.CompareExchange(ref value, max, original) == original) return max;
		}
	}

	/// <summary>Multiplies <paramref name="value"/> with <paramref name="multiplier"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be multiplied with</param>
	/// <param name="multiplier">Value to multiply <paramref name="value"/> with</param>
	/// <returns>Multiplication result</returns>
	public static long Multiply(ref long value, long multiplier)
	{
		while (true)
		{
			var original = value;
			var result = original * multiplier;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Divides <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division result</returns>
	public static long Divide(ref long value, long divisor)
	{
		while (true)
		{
			var original = value;
			var result = original / divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Modulo <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division modulo result</returns>
	public static long Modulo(ref long value, long divisor)
	{
		while (true)
		{
			var original = value;
			var result = original % divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Adds <paramref name="value"/> with <paramref name="add"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be added with</param>
	/// <param name="add">Value to add <paramref name="value"/> with</param>
	/// <returns>Addition result</returns>
	public static long Add(ref long value, long add)
	{
		while (true)
		{
			var original = value;
			var result = original + add;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}
	
	/// <summary>Substracts <paramref name="value"/> with <paramref name="sub"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be substracted with</param>
	/// <param name="sub">Value to substract <paramref name="value"/> with</param>
	/// <returns>Substraction result</returns>
	public static long Substract(ref long value, long sub)
	{
		while (true)
		{
			var original = value;
			var result = original - sub;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Increments <paramref name="value"/> by 1</summary>
	/// <returns>Increment result</returns>
	public static long Increment(ref long value) => Add(ref value, 1);


	/// <summary>Decrements <paramref name="value"/> by 1</summary>
	/// <returns>Decrement result</returns>
	public static long Decrement(ref long value) => Substract(ref value, 1);

	
	/// <summary>Changes <paramref name="value"/> into the minimum of <paramref name="min"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="min">Minimum value to compare into</param>
	/// <returns>Minimum of <paramref name="value"/> and <paramref name="min"/></returns>
	public static ulong Min(ref ulong value, ulong min)
	{
		while (true)
		{
		    var original = value;
			if (original <= min) return original;
			if (Interlocked.CompareExchange(ref value, min, original) == original) return min;
		}
	}
	
	/// <summary>Changes <paramref name="value"/> into the maximum of <paramref name="max"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="max">Maximum value to compare into</param>
	/// <returns>Maximum of <paramref name="value"/> and <paramref name="max"/></returns>
	public static ulong Max(ref ulong value, ulong max)
	{
		while (true)
		{
		    var original = value;
			if (original >= max) return original;
			if (Interlocked.CompareExchange(ref value, max, original) == original) return max;
		}
	}

	/// <summary>Multiplies <paramref name="value"/> with <paramref name="multiplier"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be multiplied with</param>
	/// <param name="multiplier">Value to multiply <paramref name="value"/> with</param>
	/// <returns>Multiplication result</returns>
	public static ulong Multiply(ref ulong value, ulong multiplier)
	{
		while (true)
		{
			var original = value;
			var result = original * multiplier;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Divides <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division result</returns>
	public static ulong Divide(ref ulong value, ulong divisor)
	{
		while (true)
		{
			var original = value;
			var result = original / divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Modulo <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division modulo result</returns>
	public static ulong Modulo(ref ulong value, ulong divisor)
	{
		while (true)
		{
			var original = value;
			var result = original % divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Adds <paramref name="value"/> with <paramref name="add"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be added with</param>
	/// <param name="add">Value to add <paramref name="value"/> with</param>
	/// <returns>Addition result</returns>
	public static ulong Add(ref ulong value, ulong add)
	{
		while (true)
		{
			var original = value;
			var result = original + add;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}
	
	/// <summary>Substracts <paramref name="value"/> with <paramref name="sub"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be substracted with</param>
	/// <param name="sub">Value to substract <paramref name="value"/> with</param>
	/// <returns>Substraction result</returns>
	public static ulong Substract(ref ulong value, ulong sub)
	{
		while (true)
		{
			var original = value;
			var result = original - sub;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Increments <paramref name="value"/> by 1</summary>
	/// <returns>Increment result</returns>
	public static ulong Increment(ref ulong value) => Add(ref value, 1);


	/// <summary>Decrements <paramref name="value"/> by 1</summary>
	/// <returns>Decrement result</returns>
	public static ulong Decrement(ref ulong value) => Substract(ref value, 1);

	
	/// <summary>Changes <paramref name="value"/> into the minimum of <paramref name="min"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="min">Minimum value to compare into</param>
	/// <returns>Minimum of <paramref name="value"/> and <paramref name="min"/></returns>
	public static float Min(ref float value, float min)
	{
		while (true)
		{
		    var original = value;
			if (original <= min) return original;
			if (Interlocked.CompareExchange(ref value, min, original) == original) return min;
		}
	}
	
	/// <summary>Changes <paramref name="value"/> into the maximum of <paramref name="max"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="max">Maximum value to compare into</param>
	/// <returns>Maximum of <paramref name="value"/> and <paramref name="max"/></returns>
	public static float Max(ref float value, float max)
	{
		while (true)
		{
		    var original = value;
			if (original >= max) return original;
			if (Interlocked.CompareExchange(ref value, max, original) == original) return max;
		}
	}

	/// <summary>Multiplies <paramref name="value"/> with <paramref name="multiplier"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be multiplied with</param>
	/// <param name="multiplier">Value to multiply <paramref name="value"/> with</param>
	/// <returns>Multiplication result</returns>
	public static float Multiply(ref float value, float multiplier)
	{
		while (true)
		{
			var original = value;
			var result = original * multiplier;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Divides <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division result</returns>
	public static float Divide(ref float value, float divisor)
	{
		while (true)
		{
			var original = value;
			var result = original / divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Modulo <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division modulo result</returns>
	public static float Modulo(ref float value, float divisor)
	{
		while (true)
		{
			var original = value;
			var result = original % divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Adds <paramref name="value"/> with <paramref name="add"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be added with</param>
	/// <param name="add">Value to add <paramref name="value"/> with</param>
	/// <returns>Addition result</returns>
	public static float Add(ref float value, float add)
	{
		while (true)
		{
			var original = value;
			var result = original + add;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}
	
	/// <summary>Substracts <paramref name="value"/> with <paramref name="sub"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be substracted with</param>
	/// <param name="sub">Value to substract <paramref name="value"/> with</param>
	/// <returns>Substraction result</returns>
	public static float Substract(ref float value, float sub)
	{
		while (true)
		{
			var original = value;
			var result = original - sub;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Increments <paramref name="value"/> by 1</summary>
	/// <returns>Increment result</returns>
	public static float Increment(ref float value) => Add(ref value, 1);


	/// <summary>Decrements <paramref name="value"/> by 1</summary>
	/// <returns>Decrement result</returns>
	public static float Decrement(ref float value) => Substract(ref value, 1);

	
	/// <summary>Changes <paramref name="value"/> into the minimum of <paramref name="min"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="min">Minimum value to compare into</param>
	/// <returns>Minimum of <paramref name="value"/> and <paramref name="min"/></returns>
	public static double Min(ref double value, double min)
	{
		while (true)
		{
		    var original = value;
			if (original <= min) return original;
			if (Interlocked.CompareExchange(ref value, min, original) == original) return min;
		}
	}
	
	/// <summary>Changes <paramref name="value"/> into the maximum of <paramref name="max"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="max">Maximum value to compare into</param>
	/// <returns>Maximum of <paramref name="value"/> and <paramref name="max"/></returns>
	public static double Max(ref double value, double max)
	{
		while (true)
		{
		    var original = value;
			if (original >= max) return original;
			if (Interlocked.CompareExchange(ref value, max, original) == original) return max;
		}
	}

	/// <summary>Multiplies <paramref name="value"/> with <paramref name="multiplier"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be multiplied with</param>
	/// <param name="multiplier">Value to multiply <paramref name="value"/> with</param>
	/// <returns>Multiplication result</returns>
	public static double Multiply(ref double value, double multiplier)
	{
		while (true)
		{
			var original = value;
			var result = original * multiplier;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Divides <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division result</returns>
	public static double Divide(ref double value, double divisor)
	{
		while (true)
		{
			var original = value;
			var result = original / divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Modulo <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division modulo result</returns>
	public static double Modulo(ref double value, double divisor)
	{
		while (true)
		{
			var original = value;
			var result = original % divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Adds <paramref name="value"/> with <paramref name="add"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be added with</param>
	/// <param name="add">Value to add <paramref name="value"/> with</param>
	/// <returns>Addition result</returns>
	public static double Add(ref double value, double add)
	{
		while (true)
		{
			var original = value;
			var result = original + add;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}
	
	/// <summary>Substracts <paramref name="value"/> with <paramref name="sub"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be substracted with</param>
	/// <param name="sub">Value to substract <paramref name="value"/> with</param>
	/// <returns>Substraction result</returns>
	public static double Substract(ref double value, double sub)
	{
		while (true)
		{
			var original = value;
			var result = original - sub;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Increments <paramref name="value"/> by 1</summary>
	/// <returns>Increment result</returns>
	public static double Increment(ref double value) => Add(ref value, 1);


	/// <summary>Decrements <paramref name="value"/> by 1</summary>
	/// <returns>Decrement result</returns>
	public static double Decrement(ref double value) => Substract(ref value, 1);

	
	/// <summary>Changes <paramref name="value"/> into the minimum of <paramref name="min"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="min">Minimum value to compare into</param>
	/// <returns>Minimum of <paramref name="value"/> and <paramref name="min"/></returns>
	public static nint Min(ref nint value, nint min)
	{
		while (true)
		{
		    var original = value;
			if (original <= min) return original;
			if (Interlocked.CompareExchange(ref value, min, original) == original) return min;
		}
	}
	
	/// <summary>Changes <paramref name="value"/> into the maximum of <paramref name="max"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="max">Maximum value to compare into</param>
	/// <returns>Maximum of <paramref name="value"/> and <paramref name="max"/></returns>
	public static nint Max(ref nint value, nint max)
	{
		while (true)
		{
		    var original = value;
			if (original >= max) return original;
			if (Interlocked.CompareExchange(ref value, max, original) == original) return max;
		}
	}

	/// <summary>Multiplies <paramref name="value"/> with <paramref name="multiplier"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be multiplied with</param>
	/// <param name="multiplier">Value to multiply <paramref name="value"/> with</param>
	/// <returns>Multiplication result</returns>
	public static nint Multiply(ref nint value, nint multiplier)
	{
		while (true)
		{
			var original = value;
			var result = original * multiplier;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Divides <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division result</returns>
	public static nint Divide(ref nint value, nint divisor)
	{
		while (true)
		{
			var original = value;
			var result = original / divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Modulo <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division modulo result</returns>
	public static nint Modulo(ref nint value, nint divisor)
	{
		while (true)
		{
			var original = value;
			var result = original % divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Adds <paramref name="value"/> with <paramref name="add"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be added with</param>
	/// <param name="add">Value to add <paramref name="value"/> with</param>
	/// <returns>Addition result</returns>
	public static nint Add(ref nint value, nint add)
	{
		while (true)
		{
			var original = value;
			var result = original + add;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}
	
	/// <summary>Substracts <paramref name="value"/> with <paramref name="sub"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be substracted with</param>
	/// <param name="sub">Value to substract <paramref name="value"/> with</param>
	/// <returns>Substraction result</returns>
	public static nint Substract(ref nint value, nint sub)
	{
		while (true)
		{
			var original = value;
			var result = original - sub;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Increments <paramref name="value"/> by 1</summary>
	/// <returns>Increment result</returns>
	public static nint Increment(ref nint value) => Add(ref value, 1);


	/// <summary>Decrements <paramref name="value"/> by 1</summary>
	/// <returns>Decrement result</returns>
	public static nint Decrement(ref nint value) => Substract(ref value, 1);

	
	/// <summary>Changes <paramref name="value"/> into the minimum of <paramref name="min"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="min">Minimum value to compare into</param>
	/// <returns>Minimum of <paramref name="value"/> and <paramref name="min"/></returns>
	public static nuint Min(ref nuint value, nuint min)
	{
		while (true)
		{
		    var original = value;
			if (original <= min) return original;
			if (Interlocked.CompareExchange(ref value, min, original) == original) return min;
		}
	}
	
	/// <summary>Changes <paramref name="value"/> into the maximum of <paramref name="max"/> or itself and return the new <paramref name="value"/> atomically.</summary>
	/// <param name="value">Reference containing the value to be changed</param>
	/// <param name="max">Maximum value to compare into</param>
	/// <returns>Maximum of <paramref name="value"/> and <paramref name="max"/></returns>
	public static nuint Max(ref nuint value, nuint max)
	{
		while (true)
		{
		    var original = value;
			if (original >= max) return original;
			if (Interlocked.CompareExchange(ref value, max, original) == original) return max;
		}
	}

	/// <summary>Multiplies <paramref name="value"/> with <paramref name="multiplier"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be multiplied with</param>
	/// <param name="multiplier">Value to multiply <paramref name="value"/> with</param>
	/// <returns>Multiplication result</returns>
	public static nuint Multiply(ref nuint value, nuint multiplier)
	{
		while (true)
		{
			var original = value;
			var result = original * multiplier;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Divides <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division result</returns>
	public static nuint Divide(ref nuint value, nuint divisor)
	{
		while (true)
		{
			var original = value;
			var result = original / divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Modulo <paramref name="value"/> with <paramref name="divisor"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be divided with</param>
	/// <param name="divisor">Value to divide <paramref name="value"/> with</param>
	/// <returns>Division modulo result</returns>
	public static nuint Modulo(ref nuint value, nuint divisor)
	{
		while (true)
		{
			var original = value;
			var result = original % divisor;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Adds <paramref name="value"/> with <paramref name="add"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be added with</param>
	/// <param name="add">Value to add <paramref name="value"/> with</param>
	/// <returns>Addition result</returns>
	public static nuint Add(ref nuint value, nuint add)
	{
		while (true)
		{
			var original = value;
			var result = original + add;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}
	
	/// <summary>Substracts <paramref name="value"/> with <paramref name="sub"/> and return the result value atomically</summary>
	/// <param name="value">Reference containing the value to be substracted with</param>
	/// <param name="sub">Value to substract <paramref name="value"/> with</param>
	/// <returns>Substraction result</returns>
	public static nuint Substract(ref nuint value, nuint sub)
	{
		while (true)
		{
			var original = value;
			var result = original - sub;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Increments <paramref name="value"/> by 1</summary>
	/// <returns>Increment result</returns>
	public static nuint Increment(ref nuint value) => Add(ref value, 1);


	/// <summary>Decrements <paramref name="value"/> by 1</summary>
	/// <returns>Decrement result</returns>
	public static nuint Decrement(ref nuint value) => Substract(ref value, 1);

	
	
	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the left</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static int ShiftLeft(ref int value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original << shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the right</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static int ShiftRight(ref int value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original >> shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the left</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static uint ShiftLeft(ref uint value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original << shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the right</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static uint ShiftRight(ref uint value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original >> shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the left</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static long ShiftLeft(ref long value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original << shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the right</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static long ShiftRight(ref long value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original >> shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the left</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static ulong ShiftLeft(ref ulong value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original << shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the right</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static ulong ShiftRight(ref ulong value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original >> shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the left</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static nint ShiftLeft(ref nint value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original << shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the right</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static nint ShiftRight(ref nint value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original >> shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the left</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static nuint ShiftLeft(ref nuint value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original << shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Shifts <paramref name="value"/> <paramref name="shift"/> bits to the right</summary>
	/// <param name="value">Reference containing the value to be shifted</param>
	/// <param name="shift">Shift amount</param>
	/// <returns>Shift result</returns>
	public static nuint ShiftRight(ref nuint value, int shift)
	{
		while (true)
		{
			var original = value;
			var result = original >> shift;
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static int Update(ref int value, Func<int, int> operation)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static int Update<TState>(ref int value, Func<int, TState, int> operation, TState state)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static uint Update(ref uint value, Func<uint, uint> operation)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static uint Update<TState>(ref uint value, Func<uint, TState, uint> operation, TState state)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static long Update(ref long value, Func<long, long> operation)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static long Update<TState>(ref long value, Func<long, TState, long> operation, TState state)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static ulong Update(ref ulong value, Func<ulong, ulong> operation)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static ulong Update<TState>(ref ulong value, Func<ulong, TState, ulong> operation, TState state)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static float Update(ref float value, Func<float, float> operation)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static float Update<TState>(ref float value, Func<float, TState, float> operation, TState state)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static double Update(ref double value, Func<double, double> operation)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static double Update<TState>(ref double value, Func<double, TState, double> operation, TState state)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static nint Update(ref nint value, Func<nint, nint> operation)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static nint Update<TState>(ref nint value, Func<nint, TState, nint> operation, TState state)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static nuint Update(ref nuint value, Func<nuint, nuint> operation)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static nuint Update<TState>(ref nuint value, Func<nuint, TState, nuint> operation, TState state)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static object Update(ref object value, Func<object, object> operation)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static object Update<TState>(ref object value, Func<object, TState, object> operation, TState state)
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (result == original || Interlocked.CompareExchange(ref value, result, original) == original) return result;
		}
	}

	
	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="T">Reference type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <returns>Update result</returns>
	public static T Update<T>(ref T value, Func<T, T> operation) where T : class
	{
	    while (true)
		{
			var original = value;
			var result = operation(original);
			if (ReferenceEquals(result, original) || ReferenceEquals(Interlocked.CompareExchange(ref value, result, original), original)) return result;
		}
	}

	/// <summary>Updates <paramref name="value"/> using <paramref name="operation"/> and returns the result <paramref name="value"/></summary>
	/// <typeparam name="T">Reference type</typeparam>
	/// <typeparam name="TState">State type</typeparam>
	/// <param name="value">Reference containing the value to update</param>
	/// <param name="operation">Operation to perform on <paramref name="value"/>. This may run multiple times.</param>
	/// <param name="state">State for <paramref name="operation"/></param>
	/// <returns>Update result</returns>
	public static T Update<T, TState>(ref T value, Func<T, TState, T> operation, TState state) where T : class
	{
	    while (true)
		{
			var original = value;
			var result = operation(original, state);
			if (ReferenceEquals(result, original) || ReferenceEquals(Interlocked.CompareExchange(ref value, result, original), original)) return result;
		}
	}
}