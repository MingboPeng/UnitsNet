﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In physics, mass (from Greek μᾶζα "barley cake, lump [of dough]") is a property of a physical system or body, giving rise to the phenomena of the body's resistance to being accelerated by a force and the strength of its mutual gravitational attraction with other bodies. Instruments such as mass balances or scales use those phenomena to measure mass. The SI unit of mass is the kilogram (kg).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Mass : IQuantity
#else
    public partial struct Mass : IQuantity, IComparable, IComparable<Mass>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MassUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public MassUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Mass()
        {
            BaseDimensions = new BaseDimensions(0, 1, 0, 0, 0, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public
#endif
        Mass(double numericValue, MassUnit unit)
        {
            if(unit == MassUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = numericValue;
            _unit = unit;
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Mass;

        /// <summary>
        ///     The base unit of Mass, which is Kilogram. All conversions go via this value.
        /// </summary>
        public static MassUnit BaseUnit => MassUnit.Kilogram;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Mass quantity.
        /// </summary>
        public static MassUnit[] Units { get; } = Enum.GetValues(typeof(MassUnit)).Cast<MassUnit>().Except(new MassUnit[]{ MassUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get Mass in Centigrams.
        /// </summary>
        public double Centigrams => As(MassUnit.Centigram);

        /// <summary>
        ///     Get Mass in Decagrams.
        /// </summary>
        public double Decagrams => As(MassUnit.Decagram);

        /// <summary>
        ///     Get Mass in Decigrams.
        /// </summary>
        public double Decigrams => As(MassUnit.Decigram);

        /// <summary>
        ///     Get Mass in Grams.
        /// </summary>
        public double Grams => As(MassUnit.Gram);

        /// <summary>
        ///     Get Mass in Hectograms.
        /// </summary>
        public double Hectograms => As(MassUnit.Hectogram);

        /// <summary>
        ///     Get Mass in Kilograms.
        /// </summary>
        public double Kilograms => As(MassUnit.Kilogram);

        /// <summary>
        ///     Get Mass in Kilopounds.
        /// </summary>
        public double Kilopounds => As(MassUnit.Kilopound);

        /// <summary>
        ///     Get Mass in Kilotonnes.
        /// </summary>
        public double Kilotonnes => As(MassUnit.Kilotonne);

        /// <summary>
        ///     Get Mass in LongHundredweight.
        /// </summary>
        public double LongHundredweight => As(MassUnit.LongHundredweight);

        /// <summary>
        ///     Get Mass in LongTons.
        /// </summary>
        public double LongTons => As(MassUnit.LongTon);

        /// <summary>
        ///     Get Mass in Megapounds.
        /// </summary>
        public double Megapounds => As(MassUnit.Megapound);

        /// <summary>
        ///     Get Mass in Megatonnes.
        /// </summary>
        public double Megatonnes => As(MassUnit.Megatonne);

        /// <summary>
        ///     Get Mass in Micrograms.
        /// </summary>
        public double Micrograms => As(MassUnit.Microgram);

        /// <summary>
        ///     Get Mass in Milligrams.
        /// </summary>
        public double Milligrams => As(MassUnit.Milligram);

        /// <summary>
        ///     Get Mass in Nanograms.
        /// </summary>
        public double Nanograms => As(MassUnit.Nanogram);

        /// <summary>
        ///     Get Mass in Ounces.
        /// </summary>
        public double Ounces => As(MassUnit.Ounce);

        /// <summary>
        ///     Get Mass in Pounds.
        /// </summary>
        public double Pounds => As(MassUnit.Pound);

        /// <summary>
        ///     Get Mass in ShortHundredweight.
        /// </summary>
        public double ShortHundredweight => As(MassUnit.ShortHundredweight);

        /// <summary>
        ///     Get Mass in ShortTons.
        /// </summary>
        public double ShortTons => As(MassUnit.ShortTon);

        /// <summary>
        ///     Get Mass in Stone.
        /// </summary>
        public double Stone => As(MassUnit.Stone);

        /// <summary>
        ///     Get Mass in Tonnes.
        /// </summary>
        public double Tonnes => As(MassUnit.Tonne);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Kilogram.
        /// </summary>
        public static Mass Zero => new Mass(0, BaseUnit);

        /// <summary>
        ///     Get Mass from Centigrams.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromCentigrams(double centigrams)
#else
        public static Mass FromCentigrams(QuantityValue centigrams)
#endif
        {
            double value = (double) centigrams;
            return new Mass(value, MassUnit.Centigram);
        }

        /// <summary>
        ///     Get Mass from Decagrams.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromDecagrams(double decagrams)
#else
        public static Mass FromDecagrams(QuantityValue decagrams)
#endif
        {
            double value = (double) decagrams;
            return new Mass(value, MassUnit.Decagram);
        }

        /// <summary>
        ///     Get Mass from Decigrams.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromDecigrams(double decigrams)
#else
        public static Mass FromDecigrams(QuantityValue decigrams)
#endif
        {
            double value = (double) decigrams;
            return new Mass(value, MassUnit.Decigram);
        }

        /// <summary>
        ///     Get Mass from Grams.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromGrams(double grams)
#else
        public static Mass FromGrams(QuantityValue grams)
#endif
        {
            double value = (double) grams;
            return new Mass(value, MassUnit.Gram);
        }

        /// <summary>
        ///     Get Mass from Hectograms.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromHectograms(double hectograms)
#else
        public static Mass FromHectograms(QuantityValue hectograms)
#endif
        {
            double value = (double) hectograms;
            return new Mass(value, MassUnit.Hectogram);
        }

        /// <summary>
        ///     Get Mass from Kilograms.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromKilograms(double kilograms)
#else
        public static Mass FromKilograms(QuantityValue kilograms)
#endif
        {
            double value = (double) kilograms;
            return new Mass(value, MassUnit.Kilogram);
        }

        /// <summary>
        ///     Get Mass from Kilopounds.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromKilopounds(double kilopounds)
#else
        public static Mass FromKilopounds(QuantityValue kilopounds)
#endif
        {
            double value = (double) kilopounds;
            return new Mass(value, MassUnit.Kilopound);
        }

        /// <summary>
        ///     Get Mass from Kilotonnes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromKilotonnes(double kilotonnes)
#else
        public static Mass FromKilotonnes(QuantityValue kilotonnes)
#endif
        {
            double value = (double) kilotonnes;
            return new Mass(value, MassUnit.Kilotonne);
        }

        /// <summary>
        ///     Get Mass from LongHundredweight.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromLongHundredweight(double longhundredweight)
#else
        public static Mass FromLongHundredweight(QuantityValue longhundredweight)
#endif
        {
            double value = (double) longhundredweight;
            return new Mass(value, MassUnit.LongHundredweight);
        }

        /// <summary>
        ///     Get Mass from LongTons.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromLongTons(double longtons)
#else
        public static Mass FromLongTons(QuantityValue longtons)
#endif
        {
            double value = (double) longtons;
            return new Mass(value, MassUnit.LongTon);
        }

        /// <summary>
        ///     Get Mass from Megapounds.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromMegapounds(double megapounds)
#else
        public static Mass FromMegapounds(QuantityValue megapounds)
#endif
        {
            double value = (double) megapounds;
            return new Mass(value, MassUnit.Megapound);
        }

        /// <summary>
        ///     Get Mass from Megatonnes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromMegatonnes(double megatonnes)
#else
        public static Mass FromMegatonnes(QuantityValue megatonnes)
#endif
        {
            double value = (double) megatonnes;
            return new Mass(value, MassUnit.Megatonne);
        }

        /// <summary>
        ///     Get Mass from Micrograms.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromMicrograms(double micrograms)
#else
        public static Mass FromMicrograms(QuantityValue micrograms)
#endif
        {
            double value = (double) micrograms;
            return new Mass(value, MassUnit.Microgram);
        }

        /// <summary>
        ///     Get Mass from Milligrams.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromMilligrams(double milligrams)
#else
        public static Mass FromMilligrams(QuantityValue milligrams)
#endif
        {
            double value = (double) milligrams;
            return new Mass(value, MassUnit.Milligram);
        }

        /// <summary>
        ///     Get Mass from Nanograms.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromNanograms(double nanograms)
#else
        public static Mass FromNanograms(QuantityValue nanograms)
#endif
        {
            double value = (double) nanograms;
            return new Mass(value, MassUnit.Nanogram);
        }

        /// <summary>
        ///     Get Mass from Ounces.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromOunces(double ounces)
#else
        public static Mass FromOunces(QuantityValue ounces)
#endif
        {
            double value = (double) ounces;
            return new Mass(value, MassUnit.Ounce);
        }

        /// <summary>
        ///     Get Mass from Pounds.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromPounds(double pounds)
#else
        public static Mass FromPounds(QuantityValue pounds)
#endif
        {
            double value = (double) pounds;
            return new Mass(value, MassUnit.Pound);
        }

        /// <summary>
        ///     Get Mass from ShortHundredweight.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromShortHundredweight(double shorthundredweight)
#else
        public static Mass FromShortHundredweight(QuantityValue shorthundredweight)
#endif
        {
            double value = (double) shorthundredweight;
            return new Mass(value, MassUnit.ShortHundredweight);
        }

        /// <summary>
        ///     Get Mass from ShortTons.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromShortTons(double shorttons)
#else
        public static Mass FromShortTons(QuantityValue shorttons)
#endif
        {
            double value = (double) shorttons;
            return new Mass(value, MassUnit.ShortTon);
        }

        /// <summary>
        ///     Get Mass from Stone.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromStone(double stone)
#else
        public static Mass FromStone(QuantityValue stone)
#endif
        {
            double value = (double) stone;
            return new Mass(value, MassUnit.Stone);
        }

        /// <summary>
        ///     Get Mass from Tonnes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Mass FromTonnes(double tonnes)
#else
        public static Mass FromTonnes(QuantityValue tonnes)
#endif
        {
            double value = (double) tonnes;
            return new Mass(value, MassUnit.Tonne);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassUnit" /> to <see cref="Mass" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Mass unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Mass From(double value, MassUnit fromUnit)
#else
        public static Mass From(QuantityValue value, MassUnit fromUnit)
#endif
        {
            return new Mass((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MassUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Mass)) throw new ArgumentException("Expected type Mass.", nameof(obj));

            return CompareTo((Mass)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Mass other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Mass within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Mass other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Mass.</returns>
        public override int GetHashCode()
        {
            return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MassUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Mass to another Mass with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Mass with the specified unit.</returns>
        public Mass ToUnit(MassUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Mass(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case MassUnit.Centigram: return (_value/1e3) * 1e-2d;
                case MassUnit.Decagram: return (_value/1e3) * 1e1d;
                case MassUnit.Decigram: return (_value/1e3) * 1e-1d;
                case MassUnit.Gram: return _value/1e3;
                case MassUnit.Hectogram: return (_value/1e3) * 1e2d;
                case MassUnit.Kilogram: return (_value/1e3) * 1e3d;
                case MassUnit.Kilopound: return (_value*0.45359237) * 1e3d;
                case MassUnit.Kilotonne: return (_value*1e3) * 1e3d;
                case MassUnit.LongHundredweight: return _value/0.01968413055222121;
                case MassUnit.LongTon: return _value*1.0160469088e3;
                case MassUnit.Megapound: return (_value*0.45359237) * 1e6d;
                case MassUnit.Megatonne: return (_value*1e3) * 1e6d;
                case MassUnit.Microgram: return (_value/1e3) * 1e-6d;
                case MassUnit.Milligram: return (_value/1e3) * 1e-3d;
                case MassUnit.Nanogram: return (_value/1e3) * 1e-9d;
                case MassUnit.Ounce: return _value/35.2739619;
                case MassUnit.Pound: return _value*0.45359237;
                case MassUnit.ShortHundredweight: return _value/0.022046226218487758;
                case MassUnit.ShortTon: return _value*9.0718474e2;
                case MassUnit.Stone: return _value/0.1574731728702698;
                case MassUnit.Tonne: return _value*1e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(MassUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case MassUnit.Centigram: return (baseUnitValue*1e3) / 1e-2d;
                case MassUnit.Decagram: return (baseUnitValue*1e3) / 1e1d;
                case MassUnit.Decigram: return (baseUnitValue*1e3) / 1e-1d;
                case MassUnit.Gram: return baseUnitValue*1e3;
                case MassUnit.Hectogram: return (baseUnitValue*1e3) / 1e2d;
                case MassUnit.Kilogram: return (baseUnitValue*1e3) / 1e3d;
                case MassUnit.Kilopound: return (baseUnitValue/0.45359237) / 1e3d;
                case MassUnit.Kilotonne: return (baseUnitValue/1e3) / 1e3d;
                case MassUnit.LongHundredweight: return baseUnitValue*0.01968413055222121;
                case MassUnit.LongTon: return baseUnitValue/1.0160469088e3;
                case MassUnit.Megapound: return (baseUnitValue/0.45359237) / 1e6d;
                case MassUnit.Megatonne: return (baseUnitValue/1e3) / 1e6d;
                case MassUnit.Microgram: return (baseUnitValue*1e3) / 1e-6d;
                case MassUnit.Milligram: return (baseUnitValue*1e3) / 1e-3d;
                case MassUnit.Nanogram: return (baseUnitValue*1e3) / 1e-9d;
                case MassUnit.Ounce: return baseUnitValue*35.2739619;
                case MassUnit.Pound: return baseUnitValue/0.45359237;
                case MassUnit.ShortHundredweight: return baseUnitValue*0.022046226218487758;
                case MassUnit.ShortTon: return baseUnitValue/9.0718474e2;
                case MassUnit.Stone: return baseUnitValue*0.1574731728702698;
                case MassUnit.Tonne: return baseUnitValue/1e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Mass Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Mass result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MassUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(MassUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Mass
        /// </summary>
        public static Mass MaxValue => new Mass(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Mass
        /// </summary>
        public static Mass MinValue => new Mass(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Mass.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Mass.BaseDimensions;
    }
}
