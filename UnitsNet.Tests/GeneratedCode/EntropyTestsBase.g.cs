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
    /// Test of Entropy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class EntropyTestsBase
    {
        protected abstract double CaloriesPerKelvinInOneJoulePerKelvin { get; }
        protected abstract double JoulesPerDegreeCelsiusInOneJoulePerKelvin { get; }
        protected abstract double JoulesPerKelvinInOneJoulePerKelvin { get; }
        protected abstract double KilocaloriesPerKelvinInOneJoulePerKelvin { get; }
        protected abstract double KilojoulesPerDegreeCelsiusInOneJoulePerKelvin { get; }
        protected abstract double KilojoulesPerKelvinInOneJoulePerKelvin { get; }
        protected abstract double MegajoulesPerKelvinInOneJoulePerKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CaloriesPerKelvinTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerDegreeCelsiusTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerKelvinTolerance { get { return 1e-5; } }
        protected virtual double KilocaloriesPerKelvinTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerDegreeCelsiusTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerKelvinTolerance { get { return 1e-5; } }
        protected virtual double MegajoulesPerKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void ConstructorWithUndefinedUnitThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Entropy((double)0.0, EntropyUnit.Undefined));
        }

        [Fact]
        public void JoulePerKelvinToEntropyUnits()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            AssertEx.EqualTolerance(CaloriesPerKelvinInOneJoulePerKelvin, jouleperkelvin.CaloriesPerKelvin, CaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(JoulesPerDegreeCelsiusInOneJoulePerKelvin, jouleperkelvin.JoulesPerDegreeCelsius, JoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(JoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(KilocaloriesPerKelvinInOneJoulePerKelvin, jouleperkelvin.KilocaloriesPerKelvin, KilocaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerDegreeCelsiusInOneJoulePerKelvin, jouleperkelvin.KilojoulesPerDegreeCelsius, KilojoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.KilojoulesPerKelvin, KilojoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.MegajoulesPerKelvin, MegajoulesPerKelvinTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Entropy.From(1, EntropyUnit.CaloriePerKelvin).CaloriesPerKelvin, CaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.From(1, EntropyUnit.JoulePerDegreeCelsius).JoulesPerDegreeCelsius, JoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, Entropy.From(1, EntropyUnit.JoulePerKelvin).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.From(1, EntropyUnit.KilocaloriePerKelvin).KilocaloriesPerKelvin, KilocaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.From(1, EntropyUnit.KilojoulePerDegreeCelsius).KilojoulesPerDegreeCelsius, KilojoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, Entropy.From(1, EntropyUnit.KilojoulePerKelvin).KilojoulesPerKelvin, KilojoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.From(1, EntropyUnit.MegajoulePerKelvin).MegajoulesPerKelvin, MegajoulesPerKelvinTolerance);
        }

        [Fact]
        public void As()
        {
            var jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            AssertEx.EqualTolerance(CaloriesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.CaloriePerKelvin), CaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(JoulesPerDegreeCelsiusInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.JoulePerDegreeCelsius), JoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(JoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.JoulePerKelvin), JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(KilocaloriesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.KilocaloriePerKelvin), KilocaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerDegreeCelsiusInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.KilojoulePerDegreeCelsius), KilojoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.KilojoulePerKelvin), KilojoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKelvinInOneJoulePerKelvin, jouleperkelvin.As(EntropyUnit.MegajoulePerKelvin), MegajoulesPerKelvinTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var jouleperkelvin = Entropy.FromJoulesPerKelvin(1);

            var calorieperkelvinQuantity = jouleperkelvin.ToUnit(EntropyUnit.CaloriePerKelvin);
            AssertEx.EqualTolerance(CaloriesPerKelvinInOneJoulePerKelvin, (double)calorieperkelvinQuantity.Value, CaloriesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.CaloriePerKelvin, calorieperkelvinQuantity.Unit);

            var jouleperdegreecelsiusQuantity = jouleperkelvin.ToUnit(EntropyUnit.JoulePerDegreeCelsius);
            AssertEx.EqualTolerance(JoulesPerDegreeCelsiusInOneJoulePerKelvin, (double)jouleperdegreecelsiusQuantity.Value, JoulesPerDegreeCelsiusTolerance);
            Assert.Equal(EntropyUnit.JoulePerDegreeCelsius, jouleperdegreecelsiusQuantity.Unit);

            var jouleperkelvinQuantity = jouleperkelvin.ToUnit(EntropyUnit.JoulePerKelvin);
            AssertEx.EqualTolerance(JoulesPerKelvinInOneJoulePerKelvin, (double)jouleperkelvinQuantity.Value, JoulesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.JoulePerKelvin, jouleperkelvinQuantity.Unit);

            var kilocalorieperkelvinQuantity = jouleperkelvin.ToUnit(EntropyUnit.KilocaloriePerKelvin);
            AssertEx.EqualTolerance(KilocaloriesPerKelvinInOneJoulePerKelvin, (double)kilocalorieperkelvinQuantity.Value, KilocaloriesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.KilocaloriePerKelvin, kilocalorieperkelvinQuantity.Unit);

            var kilojouleperdegreecelsiusQuantity = jouleperkelvin.ToUnit(EntropyUnit.KilojoulePerDegreeCelsius);
            AssertEx.EqualTolerance(KilojoulesPerDegreeCelsiusInOneJoulePerKelvin, (double)kilojouleperdegreecelsiusQuantity.Value, KilojoulesPerDegreeCelsiusTolerance);
            Assert.Equal(EntropyUnit.KilojoulePerDegreeCelsius, kilojouleperdegreecelsiusQuantity.Unit);

            var kilojouleperkelvinQuantity = jouleperkelvin.ToUnit(EntropyUnit.KilojoulePerKelvin);
            AssertEx.EqualTolerance(KilojoulesPerKelvinInOneJoulePerKelvin, (double)kilojouleperkelvinQuantity.Value, KilojoulesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.KilojoulePerKelvin, kilojouleperkelvinQuantity.Unit);

            var megajouleperkelvinQuantity = jouleperkelvin.ToUnit(EntropyUnit.MegajoulePerKelvin);
            AssertEx.EqualTolerance(MegajoulesPerKelvinInOneJoulePerKelvin, (double)megajouleperkelvinQuantity.Value, MegajoulesPerKelvinTolerance);
            Assert.Equal(EntropyUnit.MegajoulePerKelvin, megajouleperkelvinQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            AssertEx.EqualTolerance(1, Entropy.FromCaloriesPerKelvin(jouleperkelvin.CaloriesPerKelvin).JoulesPerKelvin, CaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromJoulesPerDegreeCelsius(jouleperkelvin.JoulesPerDegreeCelsius).JoulesPerKelvin, JoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromJoulesPerKelvin(jouleperkelvin.JoulesPerKelvin).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromKilocaloriesPerKelvin(jouleperkelvin.KilocaloriesPerKelvin).JoulesPerKelvin, KilocaloriesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromKilojoulesPerDegreeCelsius(jouleperkelvin.KilojoulesPerDegreeCelsius).JoulesPerKelvin, KilojoulesPerDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromKilojoulesPerKelvin(jouleperkelvin.KilojoulesPerKelvin).JoulesPerKelvin, KilojoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(1, Entropy.FromMegajoulesPerKelvin(jouleperkelvin.MegajoulesPerKelvin).JoulesPerKelvin, MegajoulesPerKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Entropy v = Entropy.FromJoulesPerKelvin(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(2, (Entropy.FromJoulesPerKelvin(3)-v).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(2, (Entropy.FromJoulesPerKelvin(10)/5).JoulesPerKelvin, JoulesPerKelvinTolerance);
            AssertEx.EqualTolerance(2, Entropy.FromJoulesPerKelvin(10)/Entropy.FromJoulesPerKelvin(5), JoulesPerKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Entropy oneJoulePerKelvin = Entropy.FromJoulesPerKelvin(1);
            Entropy twoJoulesPerKelvin = Entropy.FromJoulesPerKelvin(2);

            Assert.True(oneJoulePerKelvin < twoJoulesPerKelvin);
            Assert.True(oneJoulePerKelvin <= twoJoulesPerKelvin);
            Assert.True(twoJoulesPerKelvin > oneJoulePerKelvin);
            Assert.True(twoJoulesPerKelvin >= oneJoulePerKelvin);

            Assert.False(oneJoulePerKelvin > twoJoulesPerKelvin);
            Assert.False(oneJoulePerKelvin >= twoJoulesPerKelvin);
            Assert.False(twoJoulesPerKelvin < oneJoulePerKelvin);
            Assert.False(twoJoulesPerKelvin <= oneJoulePerKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.Equal(0, jouleperkelvin.CompareTo(jouleperkelvin));
            Assert.True(jouleperkelvin.CompareTo(Entropy.Zero) > 0);
            Assert.True(Entropy.Zero.CompareTo(jouleperkelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.Throws<ArgumentException>(() => jouleperkelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.Throws<ArgumentNullException>(() => jouleperkelvin.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Entropy v = Entropy.FromJoulesPerKelvin(1);
            Assert.True(v.Equals(Entropy.FromJoulesPerKelvin(1), JoulesPerKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Entropy.Zero, JoulesPerKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.False(jouleperkelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Entropy jouleperkelvin = Entropy.FromJoulesPerKelvin(1);
            Assert.False(jouleperkelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(EntropyUnit.Undefined, Entropy.Units);
        }
    }
}
