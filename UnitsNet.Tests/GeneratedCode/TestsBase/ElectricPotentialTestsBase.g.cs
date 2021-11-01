//------------------------------------------------------------------------------
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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricPotential.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricPotentialTestsBase : QuantityTestsBase
    {
        protected abstract double KilovoltsInOneVolt { get; }
        protected abstract double MegavoltsInOneVolt { get; }
        protected abstract double MicrovoltsInOneVolt { get; }
        protected abstract double MillivoltsInOneVolt { get; }
        protected abstract double VoltsInOneVolt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltsTolerance { get { return 1e-5; } }
        protected virtual double MegavoltsTolerance { get { return 1e-5; } }
        protected virtual double MicrovoltsTolerance { get { return 1e-5; } }
        protected virtual double MillivoltsTolerance { get { return 1e-5; } }
        protected virtual double VoltsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricPotential((double)0.0, ElectricPotentialUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricPotential();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricPotentialUnit.Volt, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricPotential(double.PositiveInfinity, ElectricPotentialUnit.Volt));
            Assert.Throws<ArgumentException>(() => new ElectricPotential(double.NegativeInfinity, ElectricPotentialUnit.Volt));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricPotential(double.NaN, ElectricPotentialUnit.Volt));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricPotential(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricPotential(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricPotential) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricPotential_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricPotential(1, ElectricPotentialUnit.Volt);

            QuantityInfo<ElectricPotentialUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricPotential.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricPotential", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricPotentialUnit>().Except(new[] {ElectricPotentialUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void VoltToElectricPotentialUnits()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            AssertEx.EqualTolerance(KilovoltsInOneVolt, volt.Kilovolts, KilovoltsTolerance);
            AssertEx.EqualTolerance(MegavoltsInOneVolt, volt.Megavolts, MegavoltsTolerance);
            AssertEx.EqualTolerance(MicrovoltsInOneVolt, volt.Microvolts, MicrovoltsTolerance);
            AssertEx.EqualTolerance(MillivoltsInOneVolt, volt.Millivolts, MillivoltsTolerance);
            AssertEx.EqualTolerance(VoltsInOneVolt, volt.Volts, VoltsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricPotential.From(1, ElectricPotentialUnit.Kilovolt);
            AssertEx.EqualTolerance(1, quantity00.Kilovolts, KilovoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Kilovolt, quantity00.Unit);

            var quantity01 = ElectricPotential.From(1, ElectricPotentialUnit.Megavolt);
            AssertEx.EqualTolerance(1, quantity01.Megavolts, MegavoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Megavolt, quantity01.Unit);

            var quantity02 = ElectricPotential.From(1, ElectricPotentialUnit.Microvolt);
            AssertEx.EqualTolerance(1, quantity02.Microvolts, MicrovoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Microvolt, quantity02.Unit);

            var quantity03 = ElectricPotential.From(1, ElectricPotentialUnit.Millivolt);
            AssertEx.EqualTolerance(1, quantity03.Millivolts, MillivoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Millivolt, quantity03.Unit);

            var quantity04 = ElectricPotential.From(1, ElectricPotentialUnit.Volt);
            AssertEx.EqualTolerance(1, quantity04.Volts, VoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Volt, quantity04.Unit);

        }

        [Fact]
        public void FromVolts_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricPotential.FromVolts(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricPotential.FromVolts(double.NegativeInfinity));
        }

        [Fact]
        public void FromVolts_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricPotential.FromVolts(double.NaN));
        }

        [Fact]
        public void As()
        {
            var volt = ElectricPotential.FromVolts(1);
            AssertEx.EqualTolerance(KilovoltsInOneVolt, volt.As(ElectricPotentialUnit.Kilovolt), KilovoltsTolerance);
            AssertEx.EqualTolerance(MegavoltsInOneVolt, volt.As(ElectricPotentialUnit.Megavolt), MegavoltsTolerance);
            AssertEx.EqualTolerance(MicrovoltsInOneVolt, volt.As(ElectricPotentialUnit.Microvolt), MicrovoltsTolerance);
            AssertEx.EqualTolerance(MillivoltsInOneVolt, volt.As(ElectricPotentialUnit.Millivolt), MillivoltsTolerance);
            AssertEx.EqualTolerance(VoltsInOneVolt, volt.As(ElectricPotentialUnit.Volt), VoltsTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricPotential(value: 1, unit: ElectricPotential.ConversionBaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var volt = ElectricPotential.FromVolts(1);

            var kilovoltQuantity = volt.ToUnit(ElectricPotentialUnit.Kilovolt);
            AssertEx.EqualTolerance(KilovoltsInOneVolt, (double)kilovoltQuantity.Value, KilovoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Kilovolt, kilovoltQuantity.Unit);

            var megavoltQuantity = volt.ToUnit(ElectricPotentialUnit.Megavolt);
            AssertEx.EqualTolerance(MegavoltsInOneVolt, (double)megavoltQuantity.Value, MegavoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Megavolt, megavoltQuantity.Unit);

            var microvoltQuantity = volt.ToUnit(ElectricPotentialUnit.Microvolt);
            AssertEx.EqualTolerance(MicrovoltsInOneVolt, (double)microvoltQuantity.Value, MicrovoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Microvolt, microvoltQuantity.Unit);

            var millivoltQuantity = volt.ToUnit(ElectricPotentialUnit.Millivolt);
            AssertEx.EqualTolerance(MillivoltsInOneVolt, (double)millivoltQuantity.Value, MillivoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Millivolt, millivoltQuantity.Unit);

            var voltQuantity = volt.ToUnit(ElectricPotentialUnit.Volt);
            AssertEx.EqualTolerance(VoltsInOneVolt, (double)voltQuantity.Value, VoltsTolerance);
            Assert.Equal(ElectricPotentialUnit.Volt, voltQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = ElectricPotential.FromVolts(1).ToBaseUnit();
            Assert.Equal(ElectricPotential.ConversionBaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            AssertEx.EqualTolerance(1, ElectricPotential.FromKilovolts(volt.Kilovolts).Volts, KilovoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.FromMegavolts(volt.Megavolts).Volts, MegavoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.FromMicrovolts(volt.Microvolts).Volts, MicrovoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.FromMillivolts(volt.Millivolts).Volts, MillivoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.FromVolts(volt.Volts).Volts, VoltsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricPotential v = ElectricPotential.FromVolts(1);
            AssertEx.EqualTolerance(-1, -v.Volts, VoltsTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotential.FromVolts(3)-v).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotential.FromVolts(10)/5).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(2, ElectricPotential.FromVolts(10)/ElectricPotential.FromVolts(5), VoltsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricPotential oneVolt = ElectricPotential.FromVolts(1);
            ElectricPotential twoVolts = ElectricPotential.FromVolts(2);

            Assert.True(oneVolt < twoVolts);
            Assert.True(oneVolt <= twoVolts);
            Assert.True(twoVolts > oneVolt);
            Assert.True(twoVolts >= oneVolt);

            Assert.False(oneVolt > twoVolts);
            Assert.False(oneVolt >= twoVolts);
            Assert.False(twoVolts < oneVolt);
            Assert.False(twoVolts <= oneVolt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.Equal(0, volt.CompareTo(volt));
            Assert.True(volt.CompareTo(ElectricPotential.Zero) > 0);
            Assert.True(ElectricPotential.Zero.CompareTo(volt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.Throws<ArgumentException>(() => volt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.Throws<ArgumentNullException>(() => volt.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricPotential.FromVolts(1);
            var b = ElectricPotential.FromVolts(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = ElectricPotential.FromVolts(1);
            var b = ElectricPotential.FromVolts(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ElectricPotential.FromVolts(1);
            object b = ElectricPotential.FromVolts(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ElectricPotential.FromVolts(1);
            Assert.True(v.Equals(ElectricPotential.FromVolts(1), VoltsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricPotential.Zero, VoltsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricPotential.FromVolts(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricPotential.FromVolts(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.False(volt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.False(volt.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricPotentialUnit.Undefined, ElectricPotential.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricPotentialUnit)).Cast<ElectricPotentialUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricPotentialUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricPotential.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 kV", new ElectricPotential(1, ElectricPotentialUnit.Kilovolt).ToString());
                Assert.Equal("1 MV", new ElectricPotential(1, ElectricPotentialUnit.Megavolt).ToString());
                Assert.Equal("1 µV", new ElectricPotential(1, ElectricPotentialUnit.Microvolt).ToString());
                Assert.Equal("1 mV", new ElectricPotential(1, ElectricPotentialUnit.Millivolt).ToString());
                Assert.Equal("1 V", new ElectricPotential(1, ElectricPotentialUnit.Volt).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 kV", new ElectricPotential(1, ElectricPotentialUnit.Kilovolt).ToString(swedishCulture));
            Assert.Equal("1 MV", new ElectricPotential(1, ElectricPotentialUnit.Megavolt).ToString(swedishCulture));
            Assert.Equal("1 µV", new ElectricPotential(1, ElectricPotentialUnit.Microvolt).ToString(swedishCulture));
            Assert.Equal("1 mV", new ElectricPotential(1, ElectricPotentialUnit.Millivolt).ToString(swedishCulture));
            Assert.Equal("1 V", new ElectricPotential(1, ElectricPotentialUnit.Volt).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 V", new ElectricPotential(0.123456, ElectricPotentialUnit.Volt).ToString("s1"));
                Assert.Equal("0.12 V", new ElectricPotential(0.123456, ElectricPotentialUnit.Volt).ToString("s2"));
                Assert.Equal("0.123 V", new ElectricPotential(0.123456, ElectricPotentialUnit.Volt).ToString("s3"));
                Assert.Equal("0.1235 V", new ElectricPotential(0.123456, ElectricPotentialUnit.Volt).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 V", new ElectricPotential(0.123456, ElectricPotentialUnit.Volt).ToString("s1", culture));
            Assert.Equal("0.12 V", new ElectricPotential(0.123456, ElectricPotentialUnit.Volt).ToString("s2", culture));
            Assert.Equal("0.123 V", new ElectricPotential(0.123456, ElectricPotentialUnit.Volt).ToString("s3", culture));
            Assert.Equal("0.1235 V", new ElectricPotential(0.123456, ElectricPotentialUnit.Volt).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentUICulture(string format)
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentUICulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricPotential)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricPotentialUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal(ElectricPotential.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal(ElectricPotential.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricPotential.FromVolts(1.0);
            Assert.Equal(new {ElectricPotential.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricPotential.FromVolts(value);
            Assert.Equal(ElectricPotential.FromVolts(-value), -quantity);
        }
    }
}
