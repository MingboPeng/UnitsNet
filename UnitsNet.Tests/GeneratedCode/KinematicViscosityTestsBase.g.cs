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
    /// Test of KinematicViscosity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class KinematicViscosityTestsBase
    {
        protected abstract double CentistokesInOneSquareMeterPerSecond { get; }
        protected abstract double DecistokesInOneSquareMeterPerSecond { get; }
        protected abstract double KilostokesInOneSquareMeterPerSecond { get; }
        protected abstract double MicrostokesInOneSquareMeterPerSecond { get; }
        protected abstract double MillistokesInOneSquareMeterPerSecond { get; }
        protected abstract double NanostokesInOneSquareMeterPerSecond { get; }
        protected abstract double SquareMetersPerSecondInOneSquareMeterPerSecond { get; }
        protected abstract double StokesInOneSquareMeterPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentistokesTolerance { get { return 1e-5; } }
        protected virtual double DecistokesTolerance { get { return 1e-5; } }
        protected virtual double KilostokesTolerance { get { return 1e-5; } }
        protected virtual double MicrostokesTolerance { get { return 1e-5; } }
        protected virtual double MillistokesTolerance { get { return 1e-5; } }
        protected virtual double NanostokesTolerance { get { return 1e-5; } }
        protected virtual double SquareMetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double StokesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void ConstructorWithUndefinedUnitThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new KinematicViscosity((double)0.0, KinematicViscosityUnit.Undefined));
        }

        [Fact]
        public void SquareMeterPerSecondToKinematicViscosityUnits()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            AssertEx.EqualTolerance(CentistokesInOneSquareMeterPerSecond, squaremeterpersecond.Centistokes, CentistokesTolerance);
            AssertEx.EqualTolerance(DecistokesInOneSquareMeterPerSecond, squaremeterpersecond.Decistokes, DecistokesTolerance);
            AssertEx.EqualTolerance(KilostokesInOneSquareMeterPerSecond, squaremeterpersecond.Kilostokes, KilostokesTolerance);
            AssertEx.EqualTolerance(MicrostokesInOneSquareMeterPerSecond, squaremeterpersecond.Microstokes, MicrostokesTolerance);
            AssertEx.EqualTolerance(MillistokesInOneSquareMeterPerSecond, squaremeterpersecond.Millistokes, MillistokesTolerance);
            AssertEx.EqualTolerance(NanostokesInOneSquareMeterPerSecond, squaremeterpersecond.Nanostokes, NanostokesTolerance);
            AssertEx.EqualTolerance(SquareMetersPerSecondInOneSquareMeterPerSecond, squaremeterpersecond.SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(StokesInOneSquareMeterPerSecond, squaremeterpersecond.Stokes, StokesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, KinematicViscosity.From(1, KinematicViscosityUnit.Centistokes).Centistokes, CentistokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.From(1, KinematicViscosityUnit.Decistokes).Decistokes, DecistokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.From(1, KinematicViscosityUnit.Kilostokes).Kilostokes, KilostokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.From(1, KinematicViscosityUnit.Microstokes).Microstokes, MicrostokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.From(1, KinematicViscosityUnit.Millistokes).Millistokes, MillistokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.From(1, KinematicViscosityUnit.Nanostokes).Nanostokes, NanostokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.From(1, KinematicViscosityUnit.SquareMeterPerSecond).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.From(1, KinematicViscosityUnit.Stokes).Stokes, StokesTolerance);
        }

        [Fact]
        public void As()
        {
            var squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            AssertEx.EqualTolerance(CentistokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Centistokes), CentistokesTolerance);
            AssertEx.EqualTolerance(DecistokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Decistokes), DecistokesTolerance);
            AssertEx.EqualTolerance(KilostokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Kilostokes), KilostokesTolerance);
            AssertEx.EqualTolerance(MicrostokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Microstokes), MicrostokesTolerance);
            AssertEx.EqualTolerance(MillistokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Millistokes), MillistokesTolerance);
            AssertEx.EqualTolerance(NanostokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Nanostokes), NanostokesTolerance);
            AssertEx.EqualTolerance(SquareMetersPerSecondInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.SquareMeterPerSecond), SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(StokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Stokes), StokesTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);

            var centistokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Centistokes);
            AssertEx.EqualTolerance(CentistokesInOneSquareMeterPerSecond, (double)centistokesQuantity.Value, CentistokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Centistokes, centistokesQuantity.Unit);

            var decistokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Decistokes);
            AssertEx.EqualTolerance(DecistokesInOneSquareMeterPerSecond, (double)decistokesQuantity.Value, DecistokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Decistokes, decistokesQuantity.Unit);

            var kilostokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Kilostokes);
            AssertEx.EqualTolerance(KilostokesInOneSquareMeterPerSecond, (double)kilostokesQuantity.Value, KilostokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Kilostokes, kilostokesQuantity.Unit);

            var microstokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Microstokes);
            AssertEx.EqualTolerance(MicrostokesInOneSquareMeterPerSecond, (double)microstokesQuantity.Value, MicrostokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Microstokes, microstokesQuantity.Unit);

            var millistokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Millistokes);
            AssertEx.EqualTolerance(MillistokesInOneSquareMeterPerSecond, (double)millistokesQuantity.Value, MillistokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Millistokes, millistokesQuantity.Unit);

            var nanostokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Nanostokes);
            AssertEx.EqualTolerance(NanostokesInOneSquareMeterPerSecond, (double)nanostokesQuantity.Value, NanostokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Nanostokes, nanostokesQuantity.Unit);

            var squaremeterpersecondQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.SquareMeterPerSecond);
            AssertEx.EqualTolerance(SquareMetersPerSecondInOneSquareMeterPerSecond, (double)squaremeterpersecondQuantity.Value, SquareMetersPerSecondTolerance);
            Assert.Equal(KinematicViscosityUnit.SquareMeterPerSecond, squaremeterpersecondQuantity.Unit);

            var stokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Stokes);
            AssertEx.EqualTolerance(StokesInOneSquareMeterPerSecond, (double)stokesQuantity.Value, StokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Stokes, stokesQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromCentistokes(squaremeterpersecond.Centistokes).SquareMetersPerSecond, CentistokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromDecistokes(squaremeterpersecond.Decistokes).SquareMetersPerSecond, DecistokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromKilostokes(squaremeterpersecond.Kilostokes).SquareMetersPerSecond, KilostokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromMicrostokes(squaremeterpersecond.Microstokes).SquareMetersPerSecond, MicrostokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromMillistokes(squaremeterpersecond.Millistokes).SquareMetersPerSecond, MillistokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromNanostokes(squaremeterpersecond.Nanostokes).SquareMetersPerSecond, NanostokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromSquareMetersPerSecond(squaremeterpersecond.SquareMetersPerSecond).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromStokes(squaremeterpersecond.Stokes).SquareMetersPerSecond, StokesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            KinematicViscosity v = KinematicViscosity.FromSquareMetersPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (KinematicViscosity.FromSquareMetersPerSecond(3)-v).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (KinematicViscosity.FromSquareMetersPerSecond(10)/5).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, KinematicViscosity.FromSquareMetersPerSecond(10)/KinematicViscosity.FromSquareMetersPerSecond(5), SquareMetersPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            KinematicViscosity oneSquareMeterPerSecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            KinematicViscosity twoSquareMetersPerSecond = KinematicViscosity.FromSquareMetersPerSecond(2);

            Assert.True(oneSquareMeterPerSecond < twoSquareMetersPerSecond);
            Assert.True(oneSquareMeterPerSecond <= twoSquareMetersPerSecond);
            Assert.True(twoSquareMetersPerSecond > oneSquareMeterPerSecond);
            Assert.True(twoSquareMetersPerSecond >= oneSquareMeterPerSecond);

            Assert.False(oneSquareMeterPerSecond > twoSquareMetersPerSecond);
            Assert.False(oneSquareMeterPerSecond >= twoSquareMetersPerSecond);
            Assert.False(twoSquareMetersPerSecond < oneSquareMeterPerSecond);
            Assert.False(twoSquareMetersPerSecond <= oneSquareMeterPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.Equal(0, squaremeterpersecond.CompareTo(squaremeterpersecond));
            Assert.True(squaremeterpersecond.CompareTo(KinematicViscosity.Zero) > 0);
            Assert.True(KinematicViscosity.Zero.CompareTo(squaremeterpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.Throws<ArgumentException>(() => squaremeterpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => squaremeterpersecond.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            KinematicViscosity v = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.True(v.Equals(KinematicViscosity.FromSquareMetersPerSecond(1), SquareMetersPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(KinematicViscosity.Zero, SquareMetersPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.False(squaremeterpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.False(squaremeterpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(KinematicViscosityUnit.Undefined, KinematicViscosity.Units);
        }
    }
}
