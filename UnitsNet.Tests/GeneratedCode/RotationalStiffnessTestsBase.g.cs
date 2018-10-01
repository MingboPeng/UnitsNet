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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of RotationalStiffness.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalStiffnessTestsBase
    {
        protected abstract double KilonewtonMetersPerRadianInOneNewtonMeterPerRadian { get; }
        protected abstract double MeganewtonMetersPerRadianInOneNewtonMeterPerRadian { get; }
        protected abstract double NewtonMetersPerRadianInOneNewtonMeterPerRadian { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilonewtonMetersPerRadianTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonMetersPerRadianTolerance { get { return 1e-5; } }
        protected virtual double NewtonMetersPerRadianTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void ConstructorWithUndefinedUnitThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffness((double)0.0, RotationalStiffnessUnit.Undefined));
        }

        [Fact]
        public void NewtonMeterPerRadianToRotationalStiffnessUnits()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.KilonewtonMetersPerRadian, KilonewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.MeganewtonMetersPerRadian, MeganewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, RotationalStiffness.From(1, RotationalStiffnessUnit.KilonewtonMeterPerRadian).KilonewtonMetersPerRadian, KilonewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffness.From(1, RotationalStiffnessUnit.MeganewtonMeterPerRadian).MeganewtonMetersPerRadian, MeganewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffness.From(1, RotationalStiffnessUnit.NewtonMeterPerRadian).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
        }

        [Fact]
        public void As()
        {
            var newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.As(RotationalStiffnessUnit.KilonewtonMeterPerRadian), KilonewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.As(RotationalStiffnessUnit.MeganewtonMeterPerRadian), MeganewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianInOneNewtonMeterPerRadian, newtonmeterperradian.As(RotationalStiffnessUnit.NewtonMeterPerRadian), NewtonMetersPerRadianTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);

            var kilonewtonmeterperradianQuantity = newtonmeterperradian.ToUnit(RotationalStiffnessUnit.KilonewtonMeterPerRadian);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianInOneNewtonMeterPerRadian, (double)kilonewtonmeterperradianQuantity.Value, KilonewtonMetersPerRadianTolerance);
            Assert.Equal(RotationalStiffnessUnit.KilonewtonMeterPerRadian, kilonewtonmeterperradianQuantity.Unit);

            var meganewtonmeterperradianQuantity = newtonmeterperradian.ToUnit(RotationalStiffnessUnit.MeganewtonMeterPerRadian);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianInOneNewtonMeterPerRadian, (double)meganewtonmeterperradianQuantity.Value, MeganewtonMetersPerRadianTolerance);
            Assert.Equal(RotationalStiffnessUnit.MeganewtonMeterPerRadian, meganewtonmeterperradianQuantity.Unit);

            var newtonmeterperradianQuantity = newtonmeterperradian.ToUnit(RotationalStiffnessUnit.NewtonMeterPerRadian);
            AssertEx.EqualTolerance(NewtonMetersPerRadianInOneNewtonMeterPerRadian, (double)newtonmeterperradianQuantity.Value, NewtonMetersPerRadianTolerance);
            Assert.Equal(RotationalStiffnessUnit.NewtonMeterPerRadian, newtonmeterperradianQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            AssertEx.EqualTolerance(1, RotationalStiffness.FromKilonewtonMetersPerRadian(newtonmeterperradian.KilonewtonMetersPerRadian).NewtonMetersPerRadian, KilonewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffness.FromMeganewtonMetersPerRadian(newtonmeterperradian.MeganewtonMetersPerRadian).NewtonMetersPerRadian, MeganewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffness.FromNewtonMetersPerRadian(newtonmeterperradian.NewtonMetersPerRadian).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalStiffness v = RotationalStiffness.FromNewtonMetersPerRadian(1);
            AssertEx.EqualTolerance(-1, -v.NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffness.FromNewtonMetersPerRadian(3)-v).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffness.FromNewtonMetersPerRadian(10)/5).NewtonMetersPerRadian, NewtonMetersPerRadianTolerance);
            AssertEx.EqualTolerance(2, RotationalStiffness.FromNewtonMetersPerRadian(10)/RotationalStiffness.FromNewtonMetersPerRadian(5), NewtonMetersPerRadianTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalStiffness oneNewtonMeterPerRadian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            RotationalStiffness twoNewtonMetersPerRadian = RotationalStiffness.FromNewtonMetersPerRadian(2);

            Assert.True(oneNewtonMeterPerRadian < twoNewtonMetersPerRadian);
            Assert.True(oneNewtonMeterPerRadian <= twoNewtonMetersPerRadian);
            Assert.True(twoNewtonMetersPerRadian > oneNewtonMeterPerRadian);
            Assert.True(twoNewtonMetersPerRadian >= oneNewtonMeterPerRadian);

            Assert.False(oneNewtonMeterPerRadian > twoNewtonMetersPerRadian);
            Assert.False(oneNewtonMeterPerRadian >= twoNewtonMetersPerRadian);
            Assert.False(twoNewtonMetersPerRadian < oneNewtonMeterPerRadian);
            Assert.False(twoNewtonMetersPerRadian <= oneNewtonMeterPerRadian);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.Equal(0, newtonmeterperradian.CompareTo(newtonmeterperradian));
            Assert.True(newtonmeterperradian.CompareTo(RotationalStiffness.Zero) > 0);
            Assert.True(RotationalStiffness.Zero.CompareTo(newtonmeterperradian) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.Throws<ArgumentException>(() => newtonmeterperradian.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.Throws<ArgumentNullException>(() => newtonmeterperradian.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            RotationalStiffness v = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.True(v.Equals(RotationalStiffness.FromNewtonMetersPerRadian(1), NewtonMetersPerRadianTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RotationalStiffness.Zero, NewtonMetersPerRadianTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.False(newtonmeterperradian.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalStiffness newtonmeterperradian = RotationalStiffness.FromNewtonMetersPerRadian(1);
            Assert.False(newtonmeterperradian.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RotationalStiffnessUnit.Undefined, RotationalStiffness.Units);
        }
    }
}
