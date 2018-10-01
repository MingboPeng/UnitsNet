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
    ///     Many different units of length have been used around the world. The main units in modern use are U.S. customary units in the United States and the Metric system elsewhere. British Imperial units are still used for some purposes in the United Kingdom and some other countries. The metric system is sub-divided into SI and non-SI units.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Length : IQuantity
#else
    public partial struct Length : IQuantity, IComparable, IComparable<Length>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly LengthUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public LengthUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Length()
        {
            BaseDimensions = new BaseDimensions(1, 0, 0, 0, 0, 0, 0);
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
        Length(double numericValue, LengthUnit unit)
        {
            if(unit == LengthUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = numericValue;
            _unit = unit;
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Length;

        /// <summary>
        ///     The base unit of Length, which is Meter. All conversions go via this value.
        /// </summary>
        public static LengthUnit BaseUnit => LengthUnit.Meter;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Length quantity.
        /// </summary>
        public static LengthUnit[] Units { get; } = Enum.GetValues(typeof(LengthUnit)).Cast<LengthUnit>().Except(new LengthUnit[]{ LengthUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get Length in Centimeters.
        /// </summary>
        public double Centimeters => As(LengthUnit.Centimeter);

        /// <summary>
        ///     Get Length in Decimeters.
        /// </summary>
        public double Decimeters => As(LengthUnit.Decimeter);

        /// <summary>
        ///     Get Length in DtpPicas.
        /// </summary>
        public double DtpPicas => As(LengthUnit.DtpPica);

        /// <summary>
        ///     Get Length in DtpPoints.
        /// </summary>
        public double DtpPoints => As(LengthUnit.DtpPoint);

        /// <summary>
        ///     Get Length in Fathoms.
        /// </summary>
        public double Fathoms => As(LengthUnit.Fathom);

        /// <summary>
        ///     Get Length in Feet.
        /// </summary>
        public double Feet => As(LengthUnit.Foot);

        /// <summary>
        ///     Get Length in Inches.
        /// </summary>
        public double Inches => As(LengthUnit.Inch);

        /// <summary>
        ///     Get Length in Kilometers.
        /// </summary>
        public double Kilometers => As(LengthUnit.Kilometer);

        /// <summary>
        ///     Get Length in Meters.
        /// </summary>
        public double Meters => As(LengthUnit.Meter);

        /// <summary>
        ///     Get Length in Microinches.
        /// </summary>
        public double Microinches => As(LengthUnit.Microinch);

        /// <summary>
        ///     Get Length in Micrometers.
        /// </summary>
        public double Micrometers => As(LengthUnit.Micrometer);

        /// <summary>
        ///     Get Length in Mils.
        /// </summary>
        public double Mils => As(LengthUnit.Mil);

        /// <summary>
        ///     Get Length in Miles.
        /// </summary>
        public double Miles => As(LengthUnit.Mile);

        /// <summary>
        ///     Get Length in Millimeters.
        /// </summary>
        public double Millimeters => As(LengthUnit.Millimeter);

        /// <summary>
        ///     Get Length in Nanometers.
        /// </summary>
        public double Nanometers => As(LengthUnit.Nanometer);

        /// <summary>
        ///     Get Length in NauticalMiles.
        /// </summary>
        public double NauticalMiles => As(LengthUnit.NauticalMile);

        /// <summary>
        ///     Get Length in PrinterPicas.
        /// </summary>
        public double PrinterPicas => As(LengthUnit.PrinterPica);

        /// <summary>
        ///     Get Length in PrinterPoints.
        /// </summary>
        public double PrinterPoints => As(LengthUnit.PrinterPoint);

        /// <summary>
        ///     Get Length in Shackles.
        /// </summary>
        public double Shackles => As(LengthUnit.Shackle);

        /// <summary>
        ///     Get Length in Twips.
        /// </summary>
        public double Twips => As(LengthUnit.Twip);

        /// <summary>
        ///     Get Length in UsSurveyFeet.
        /// </summary>
        public double UsSurveyFeet => As(LengthUnit.UsSurveyFoot);

        /// <summary>
        ///     Get Length in Yards.
        /// </summary>
        public double Yards => As(LengthUnit.Yard);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Meter.
        /// </summary>
        public static Length Zero => new Length(0, BaseUnit);

        /// <summary>
        ///     Get Length from Centimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromCentimeters(double centimeters)
#else
        public static Length FromCentimeters(QuantityValue centimeters)
#endif
        {
            double value = (double) centimeters;
            return new Length(value, LengthUnit.Centimeter);
        }

        /// <summary>
        ///     Get Length from Decimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromDecimeters(double decimeters)
#else
        public static Length FromDecimeters(QuantityValue decimeters)
#endif
        {
            double value = (double) decimeters;
            return new Length(value, LengthUnit.Decimeter);
        }

        /// <summary>
        ///     Get Length from DtpPicas.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromDtpPicas(double dtppicas)
#else
        public static Length FromDtpPicas(QuantityValue dtppicas)
#endif
        {
            double value = (double) dtppicas;
            return new Length(value, LengthUnit.DtpPica);
        }

        /// <summary>
        ///     Get Length from DtpPoints.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromDtpPoints(double dtppoints)
#else
        public static Length FromDtpPoints(QuantityValue dtppoints)
#endif
        {
            double value = (double) dtppoints;
            return new Length(value, LengthUnit.DtpPoint);
        }

        /// <summary>
        ///     Get Length from Fathoms.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromFathoms(double fathoms)
#else
        public static Length FromFathoms(QuantityValue fathoms)
#endif
        {
            double value = (double) fathoms;
            return new Length(value, LengthUnit.Fathom);
        }

        /// <summary>
        ///     Get Length from Feet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromFeet(double feet)
#else
        public static Length FromFeet(QuantityValue feet)
#endif
        {
            double value = (double) feet;
            return new Length(value, LengthUnit.Foot);
        }

        /// <summary>
        ///     Get Length from Inches.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromInches(double inches)
#else
        public static Length FromInches(QuantityValue inches)
#endif
        {
            double value = (double) inches;
            return new Length(value, LengthUnit.Inch);
        }

        /// <summary>
        ///     Get Length from Kilometers.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromKilometers(double kilometers)
#else
        public static Length FromKilometers(QuantityValue kilometers)
#endif
        {
            double value = (double) kilometers;
            return new Length(value, LengthUnit.Kilometer);
        }

        /// <summary>
        ///     Get Length from Meters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromMeters(double meters)
#else
        public static Length FromMeters(QuantityValue meters)
#endif
        {
            double value = (double) meters;
            return new Length(value, LengthUnit.Meter);
        }

        /// <summary>
        ///     Get Length from Microinches.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromMicroinches(double microinches)
#else
        public static Length FromMicroinches(QuantityValue microinches)
#endif
        {
            double value = (double) microinches;
            return new Length(value, LengthUnit.Microinch);
        }

        /// <summary>
        ///     Get Length from Micrometers.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromMicrometers(double micrometers)
#else
        public static Length FromMicrometers(QuantityValue micrometers)
#endif
        {
            double value = (double) micrometers;
            return new Length(value, LengthUnit.Micrometer);
        }

        /// <summary>
        ///     Get Length from Mils.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromMils(double mils)
#else
        public static Length FromMils(QuantityValue mils)
#endif
        {
            double value = (double) mils;
            return new Length(value, LengthUnit.Mil);
        }

        /// <summary>
        ///     Get Length from Miles.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromMiles(double miles)
#else
        public static Length FromMiles(QuantityValue miles)
#endif
        {
            double value = (double) miles;
            return new Length(value, LengthUnit.Mile);
        }

        /// <summary>
        ///     Get Length from Millimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromMillimeters(double millimeters)
#else
        public static Length FromMillimeters(QuantityValue millimeters)
#endif
        {
            double value = (double) millimeters;
            return new Length(value, LengthUnit.Millimeter);
        }

        /// <summary>
        ///     Get Length from Nanometers.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromNanometers(double nanometers)
#else
        public static Length FromNanometers(QuantityValue nanometers)
#endif
        {
            double value = (double) nanometers;
            return new Length(value, LengthUnit.Nanometer);
        }

        /// <summary>
        ///     Get Length from NauticalMiles.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromNauticalMiles(double nauticalmiles)
#else
        public static Length FromNauticalMiles(QuantityValue nauticalmiles)
#endif
        {
            double value = (double) nauticalmiles;
            return new Length(value, LengthUnit.NauticalMile);
        }

        /// <summary>
        ///     Get Length from PrinterPicas.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromPrinterPicas(double printerpicas)
#else
        public static Length FromPrinterPicas(QuantityValue printerpicas)
#endif
        {
            double value = (double) printerpicas;
            return new Length(value, LengthUnit.PrinterPica);
        }

        /// <summary>
        ///     Get Length from PrinterPoints.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromPrinterPoints(double printerpoints)
#else
        public static Length FromPrinterPoints(QuantityValue printerpoints)
#endif
        {
            double value = (double) printerpoints;
            return new Length(value, LengthUnit.PrinterPoint);
        }

        /// <summary>
        ///     Get Length from Shackles.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromShackles(double shackles)
#else
        public static Length FromShackles(QuantityValue shackles)
#endif
        {
            double value = (double) shackles;
            return new Length(value, LengthUnit.Shackle);
        }

        /// <summary>
        ///     Get Length from Twips.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromTwips(double twips)
#else
        public static Length FromTwips(QuantityValue twips)
#endif
        {
            double value = (double) twips;
            return new Length(value, LengthUnit.Twip);
        }

        /// <summary>
        ///     Get Length from UsSurveyFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromUsSurveyFeet(double ussurveyfeet)
#else
        public static Length FromUsSurveyFeet(QuantityValue ussurveyfeet)
#endif
        {
            double value = (double) ussurveyfeet;
            return new Length(value, LengthUnit.UsSurveyFoot);
        }

        /// <summary>
        ///     Get Length from Yards.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Length FromYards(double yards)
#else
        public static Length FromYards(QuantityValue yards)
#endif
        {
            double value = (double) yards;
            return new Length(value, LengthUnit.Yard);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LengthUnit" /> to <see cref="Length" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Length unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Length From(double value, LengthUnit fromUnit)
#else
        public static Length From(QuantityValue value, LengthUnit fromUnit)
#endif
        {
            return new Length((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(LengthUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Length)) throw new ArgumentException("Expected type Length.", nameof(obj));

            return CompareTo((Length)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Length other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Length within the given absolute or relative tolerance.
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
        public bool Equals(Length other, double tolerance, ComparisonType comparisonType)
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
        /// <returns>A hash code for the current Length.</returns>
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
        public double As(LengthUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Length to another Length with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Length with the specified unit.</returns>
        public Length ToUnit(LengthUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Length(convertedValue, unit);
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
                case LengthUnit.Centimeter: return (_value) * 1e-2d;
                case LengthUnit.Decimeter: return (_value) * 1e-1d;
                case LengthUnit.DtpPica: return _value/236.220472441;
                case LengthUnit.DtpPoint: return (_value/72)*2.54e-2;
                case LengthUnit.Fathom: return _value*1.8288;
                case LengthUnit.Foot: return _value*0.3048;
                case LengthUnit.Inch: return _value*2.54e-2;
                case LengthUnit.Kilometer: return (_value) * 1e3d;
                case LengthUnit.Meter: return _value;
                case LengthUnit.Microinch: return _value*2.54e-8;
                case LengthUnit.Micrometer: return (_value) * 1e-6d;
                case LengthUnit.Mil: return _value*2.54e-5;
                case LengthUnit.Mile: return _value*1609.34;
                case LengthUnit.Millimeter: return (_value) * 1e-3d;
                case LengthUnit.Nanometer: return (_value) * 1e-9d;
                case LengthUnit.NauticalMile: return _value*1852;
                case LengthUnit.PrinterPica: return _value/237.106301584;
                case LengthUnit.PrinterPoint: return (_value/72.27)*2.54e-2;
                case LengthUnit.Shackle: return _value*27.432;
                case LengthUnit.Twip: return _value/56692.913385826;
                case LengthUnit.UsSurveyFoot: return _value*1200/3937;
                case LengthUnit.Yard: return _value*0.9144;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(LengthUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case LengthUnit.Centimeter: return (baseUnitValue) / 1e-2d;
                case LengthUnit.Decimeter: return (baseUnitValue) / 1e-1d;
                case LengthUnit.DtpPica: return baseUnitValue*236.220472441;
                case LengthUnit.DtpPoint: return (baseUnitValue/2.54e-2)*72;
                case LengthUnit.Fathom: return baseUnitValue/1.8288;
                case LengthUnit.Foot: return baseUnitValue/0.3048;
                case LengthUnit.Inch: return baseUnitValue/2.54e-2;
                case LengthUnit.Kilometer: return (baseUnitValue) / 1e3d;
                case LengthUnit.Meter: return baseUnitValue;
                case LengthUnit.Microinch: return baseUnitValue/2.54e-8;
                case LengthUnit.Micrometer: return (baseUnitValue) / 1e-6d;
                case LengthUnit.Mil: return baseUnitValue/2.54e-5;
                case LengthUnit.Mile: return baseUnitValue/1609.34;
                case LengthUnit.Millimeter: return (baseUnitValue) / 1e-3d;
                case LengthUnit.Nanometer: return (baseUnitValue) / 1e-9d;
                case LengthUnit.NauticalMile: return baseUnitValue/1852;
                case LengthUnit.PrinterPica: return baseUnitValue*237.106301584;
                case LengthUnit.PrinterPoint: return (baseUnitValue/2.54e-2)*72.27;
                case LengthUnit.Shackle: return baseUnitValue/27.432;
                case LengthUnit.Twip: return baseUnitValue*56692.913385826;
                case LengthUnit.UsSurveyFoot: return baseUnitValue*3937/1200;
                case LengthUnit.Yard: return baseUnitValue/0.9144;
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
        public static Length Parse(string str)
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
        public static bool TryParse([CanBeNull] string str, out Length result)
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
        public static LengthUnit ParseUnit(string str)
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
        public string ToString(LengthUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Length
        /// </summary>
        public static Length MaxValue => new Length(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Length
        /// </summary>
        public static Length MinValue => new Length(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Length.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Length.BaseDimensions;
    }
}
