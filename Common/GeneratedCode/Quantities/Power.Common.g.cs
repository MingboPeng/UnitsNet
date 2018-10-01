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
    ///     In physics, power is the rate of doing work. It is equivalent to an amount of energy consumed per unit time.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Power : IQuantity
#else
    public partial struct Power : IQuantity, IComparable, IComparable<Power>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly decimal _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly PowerUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public PowerUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Power()
        {
            BaseDimensions = new BaseDimensions(2, 1, -3, 0, 0, 0, 0);
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
        Power(decimal numericValue, PowerUnit unit)
        {
            if(unit == PowerUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = numericValue;
            _unit = unit;
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Power;

        /// <summary>
        ///     The base unit of Power, which is Watt. All conversions go via this value.
        /// </summary>
        public static PowerUnit BaseUnit => PowerUnit.Watt;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Power quantity.
        /// </summary>
        public static PowerUnit[] Units { get; } = Enum.GetValues(typeof(PowerUnit)).Cast<PowerUnit>().Except(new PowerUnit[]{ PowerUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get Power in BoilerHorsepower.
        /// </summary>
        public double BoilerHorsepower => As(PowerUnit.BoilerHorsepower);

        /// <summary>
        ///     Get Power in BritishThermalUnitsPerHour.
        /// </summary>
        public double BritishThermalUnitsPerHour => As(PowerUnit.BritishThermalUnitPerHour);

        /// <summary>
        ///     Get Power in Decawatts.
        /// </summary>
        public double Decawatts => As(PowerUnit.Decawatt);

        /// <summary>
        ///     Get Power in Deciwatts.
        /// </summary>
        public double Deciwatts => As(PowerUnit.Deciwatt);

        /// <summary>
        ///     Get Power in ElectricalHorsepower.
        /// </summary>
        public double ElectricalHorsepower => As(PowerUnit.ElectricalHorsepower);

        /// <summary>
        ///     Get Power in Femtowatts.
        /// </summary>
        public double Femtowatts => As(PowerUnit.Femtowatt);

        /// <summary>
        ///     Get Power in Gigawatts.
        /// </summary>
        public double Gigawatts => As(PowerUnit.Gigawatt);

        /// <summary>
        ///     Get Power in HydraulicHorsepower.
        /// </summary>
        public double HydraulicHorsepower => As(PowerUnit.HydraulicHorsepower);

        /// <summary>
        ///     Get Power in KilobritishThermalUnitsPerHour.
        /// </summary>
        public double KilobritishThermalUnitsPerHour => As(PowerUnit.KilobritishThermalUnitPerHour);

        /// <summary>
        ///     Get Power in Kilowatts.
        /// </summary>
        public double Kilowatts => As(PowerUnit.Kilowatt);

        /// <summary>
        ///     Get Power in MechanicalHorsepower.
        /// </summary>
        public double MechanicalHorsepower => As(PowerUnit.MechanicalHorsepower);

        /// <summary>
        ///     Get Power in Megawatts.
        /// </summary>
        public double Megawatts => As(PowerUnit.Megawatt);

        /// <summary>
        ///     Get Power in MetricHorsepower.
        /// </summary>
        public double MetricHorsepower => As(PowerUnit.MetricHorsepower);

        /// <summary>
        ///     Get Power in Microwatts.
        /// </summary>
        public double Microwatts => As(PowerUnit.Microwatt);

        /// <summary>
        ///     Get Power in Milliwatts.
        /// </summary>
        public double Milliwatts => As(PowerUnit.Milliwatt);

        /// <summary>
        ///     Get Power in Nanowatts.
        /// </summary>
        public double Nanowatts => As(PowerUnit.Nanowatt);

        /// <summary>
        ///     Get Power in Petawatts.
        /// </summary>
        public double Petawatts => As(PowerUnit.Petawatt);

        /// <summary>
        ///     Get Power in Picowatts.
        /// </summary>
        public double Picowatts => As(PowerUnit.Picowatt);

        /// <summary>
        ///     Get Power in Terawatts.
        /// </summary>
        public double Terawatts => As(PowerUnit.Terawatt);

        /// <summary>
        ///     Get Power in Watts.
        /// </summary>
        public double Watts => As(PowerUnit.Watt);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Watt.
        /// </summary>
        public static Power Zero => new Power(0, BaseUnit);

        /// <summary>
        ///     Get Power from BoilerHorsepower.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromBoilerHorsepower(double boilerhorsepower)
#else
        public static Power FromBoilerHorsepower(QuantityValue boilerhorsepower)
#endif
        {
            decimal value = (decimal) boilerhorsepower;
            return new Power(value, PowerUnit.BoilerHorsepower);
        }

        /// <summary>
        ///     Get Power from BritishThermalUnitsPerHour.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromBritishThermalUnitsPerHour(double britishthermalunitsperhour)
#else
        public static Power FromBritishThermalUnitsPerHour(QuantityValue britishthermalunitsperhour)
#endif
        {
            decimal value = (decimal) britishthermalunitsperhour;
            return new Power(value, PowerUnit.BritishThermalUnitPerHour);
        }

        /// <summary>
        ///     Get Power from Decawatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromDecawatts(double decawatts)
#else
        public static Power FromDecawatts(QuantityValue decawatts)
#endif
        {
            decimal value = (decimal) decawatts;
            return new Power(value, PowerUnit.Decawatt);
        }

        /// <summary>
        ///     Get Power from Deciwatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromDeciwatts(double deciwatts)
#else
        public static Power FromDeciwatts(QuantityValue deciwatts)
#endif
        {
            decimal value = (decimal) deciwatts;
            return new Power(value, PowerUnit.Deciwatt);
        }

        /// <summary>
        ///     Get Power from ElectricalHorsepower.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromElectricalHorsepower(double electricalhorsepower)
#else
        public static Power FromElectricalHorsepower(QuantityValue electricalhorsepower)
#endif
        {
            decimal value = (decimal) electricalhorsepower;
            return new Power(value, PowerUnit.ElectricalHorsepower);
        }

        /// <summary>
        ///     Get Power from Femtowatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromFemtowatts(double femtowatts)
#else
        public static Power FromFemtowatts(QuantityValue femtowatts)
#endif
        {
            decimal value = (decimal) femtowatts;
            return new Power(value, PowerUnit.Femtowatt);
        }

        /// <summary>
        ///     Get Power from Gigawatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromGigawatts(double gigawatts)
#else
        public static Power FromGigawatts(QuantityValue gigawatts)
#endif
        {
            decimal value = (decimal) gigawatts;
            return new Power(value, PowerUnit.Gigawatt);
        }

        /// <summary>
        ///     Get Power from HydraulicHorsepower.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromHydraulicHorsepower(double hydraulichorsepower)
#else
        public static Power FromHydraulicHorsepower(QuantityValue hydraulichorsepower)
#endif
        {
            decimal value = (decimal) hydraulichorsepower;
            return new Power(value, PowerUnit.HydraulicHorsepower);
        }

        /// <summary>
        ///     Get Power from KilobritishThermalUnitsPerHour.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromKilobritishThermalUnitsPerHour(double kilobritishthermalunitsperhour)
#else
        public static Power FromKilobritishThermalUnitsPerHour(QuantityValue kilobritishthermalunitsperhour)
#endif
        {
            decimal value = (decimal) kilobritishthermalunitsperhour;
            return new Power(value, PowerUnit.KilobritishThermalUnitPerHour);
        }

        /// <summary>
        ///     Get Power from Kilowatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromKilowatts(double kilowatts)
#else
        public static Power FromKilowatts(QuantityValue kilowatts)
#endif
        {
            decimal value = (decimal) kilowatts;
            return new Power(value, PowerUnit.Kilowatt);
        }

        /// <summary>
        ///     Get Power from MechanicalHorsepower.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromMechanicalHorsepower(double mechanicalhorsepower)
#else
        public static Power FromMechanicalHorsepower(QuantityValue mechanicalhorsepower)
#endif
        {
            decimal value = (decimal) mechanicalhorsepower;
            return new Power(value, PowerUnit.MechanicalHorsepower);
        }

        /// <summary>
        ///     Get Power from Megawatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromMegawatts(double megawatts)
#else
        public static Power FromMegawatts(QuantityValue megawatts)
#endif
        {
            decimal value = (decimal) megawatts;
            return new Power(value, PowerUnit.Megawatt);
        }

        /// <summary>
        ///     Get Power from MetricHorsepower.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromMetricHorsepower(double metrichorsepower)
#else
        public static Power FromMetricHorsepower(QuantityValue metrichorsepower)
#endif
        {
            decimal value = (decimal) metrichorsepower;
            return new Power(value, PowerUnit.MetricHorsepower);
        }

        /// <summary>
        ///     Get Power from Microwatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromMicrowatts(double microwatts)
#else
        public static Power FromMicrowatts(QuantityValue microwatts)
#endif
        {
            decimal value = (decimal) microwatts;
            return new Power(value, PowerUnit.Microwatt);
        }

        /// <summary>
        ///     Get Power from Milliwatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromMilliwatts(double milliwatts)
#else
        public static Power FromMilliwatts(QuantityValue milliwatts)
#endif
        {
            decimal value = (decimal) milliwatts;
            return new Power(value, PowerUnit.Milliwatt);
        }

        /// <summary>
        ///     Get Power from Nanowatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromNanowatts(double nanowatts)
#else
        public static Power FromNanowatts(QuantityValue nanowatts)
#endif
        {
            decimal value = (decimal) nanowatts;
            return new Power(value, PowerUnit.Nanowatt);
        }

        /// <summary>
        ///     Get Power from Petawatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromPetawatts(double petawatts)
#else
        public static Power FromPetawatts(QuantityValue petawatts)
#endif
        {
            decimal value = (decimal) petawatts;
            return new Power(value, PowerUnit.Petawatt);
        }

        /// <summary>
        ///     Get Power from Picowatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromPicowatts(double picowatts)
#else
        public static Power FromPicowatts(QuantityValue picowatts)
#endif
        {
            decimal value = (decimal) picowatts;
            return new Power(value, PowerUnit.Picowatt);
        }

        /// <summary>
        ///     Get Power from Terawatts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromTerawatts(double terawatts)
#else
        public static Power FromTerawatts(QuantityValue terawatts)
#endif
        {
            decimal value = (decimal) terawatts;
            return new Power(value, PowerUnit.Terawatt);
        }

        /// <summary>
        ///     Get Power from Watts.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Power FromWatts(double watts)
#else
        public static Power FromWatts(QuantityValue watts)
#endif
        {
            decimal value = (decimal) watts;
            return new Power(value, PowerUnit.Watt);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PowerUnit" /> to <see cref="Power" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Power unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Power From(double value, PowerUnit fromUnit)
#else
        public static Power From(QuantityValue value, PowerUnit fromUnit)
#endif
        {
            return new Power((decimal)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(PowerUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Power)) throw new ArgumentException("Expected type Power.", nameof(obj));

            return CompareTo((Power)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Power other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Power within the given absolute or relative tolerance.
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
        public bool Equals(Power other, double tolerance, ComparisonType comparisonType)
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
        /// <returns>A hash code for the current Power.</returns>
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
        public double As(PowerUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Power to another Power with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Power with the specified unit.</returns>
        public Power ToUnit(PowerUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Power(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private decimal AsBaseUnit()
        {
            switch(Unit)
            {
                case PowerUnit.BoilerHorsepower: return _value*9812.5m;
                case PowerUnit.BritishThermalUnitPerHour: return _value*0.293071m;
                case PowerUnit.Decawatt: return (_value) * 1e1m;
                case PowerUnit.Deciwatt: return (_value) * 1e-1m;
                case PowerUnit.ElectricalHorsepower: return _value*746m;
                case PowerUnit.Femtowatt: return (_value) * 1e-15m;
                case PowerUnit.Gigawatt: return (_value) * 1e9m;
                case PowerUnit.HydraulicHorsepower: return _value*745.69988145m;
                case PowerUnit.KilobritishThermalUnitPerHour: return (_value*0.293071m) * 1e3m;
                case PowerUnit.Kilowatt: return (_value) * 1e3m;
                case PowerUnit.MechanicalHorsepower: return _value*745.69m;
                case PowerUnit.Megawatt: return (_value) * 1e6m;
                case PowerUnit.MetricHorsepower: return _value*735.49875m;
                case PowerUnit.Microwatt: return (_value) * 1e-6m;
                case PowerUnit.Milliwatt: return (_value) * 1e-3m;
                case PowerUnit.Nanowatt: return (_value) * 1e-9m;
                case PowerUnit.Petawatt: return (_value) * 1e15m;
                case PowerUnit.Picowatt: return (_value) * 1e-12m;
                case PowerUnit.Terawatt: return (_value) * 1e12m;
                case PowerUnit.Watt: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private decimal AsBaseNumericType(PowerUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case PowerUnit.BoilerHorsepower: return baseUnitValue/9812.5m;
                case PowerUnit.BritishThermalUnitPerHour: return baseUnitValue/0.293071m;
                case PowerUnit.Decawatt: return (baseUnitValue) / 1e1m;
                case PowerUnit.Deciwatt: return (baseUnitValue) / 1e-1m;
                case PowerUnit.ElectricalHorsepower: return baseUnitValue/746m;
                case PowerUnit.Femtowatt: return (baseUnitValue) / 1e-15m;
                case PowerUnit.Gigawatt: return (baseUnitValue) / 1e9m;
                case PowerUnit.HydraulicHorsepower: return baseUnitValue/745.69988145m;
                case PowerUnit.KilobritishThermalUnitPerHour: return (baseUnitValue/0.293071m) / 1e3m;
                case PowerUnit.Kilowatt: return (baseUnitValue) / 1e3m;
                case PowerUnit.MechanicalHorsepower: return baseUnitValue/745.69m;
                case PowerUnit.Megawatt: return (baseUnitValue) / 1e6m;
                case PowerUnit.MetricHorsepower: return baseUnitValue/735.49875m;
                case PowerUnit.Microwatt: return (baseUnitValue) / 1e-6m;
                case PowerUnit.Milliwatt: return (baseUnitValue) / 1e-3m;
                case PowerUnit.Nanowatt: return (baseUnitValue) / 1e-9m;
                case PowerUnit.Petawatt: return (baseUnitValue) / 1e15m;
                case PowerUnit.Picowatt: return (baseUnitValue) / 1e-12m;
                case PowerUnit.Terawatt: return (baseUnitValue) / 1e12m;
                case PowerUnit.Watt: return baseUnitValue;
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
        public static Power Parse(string str)
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
        public static bool TryParse([CanBeNull] string str, out Power result)
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
        public static PowerUnit ParseUnit(string str)
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
        public string ToString(PowerUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Power
        /// </summary>
        public static Power MaxValue => new Power(decimal.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Power
        /// </summary>
        public static Power MinValue => new Power(decimal.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Power.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Power.BaseDimensions;
    }
}
