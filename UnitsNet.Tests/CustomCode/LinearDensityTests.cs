﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.


using System;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class LinearDensityTests : LinearDensityTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;

        protected override double MicrogramsPerMillimeterInOneKilogramPerMeter => 1e6;
        protected override double MicrogramsPerCentimeterInOneKilogramPerMeter => 1e7;
        protected override double MicrogramsPerMeterInOneKilogramPerMeter => 1e9;

        protected override double MilligramsPerMillimeterInOneKilogramPerMeter => 1e3;
        protected override double MilligramsPerCentimeterInOneKilogramPerMeter => 1e4;
        protected override double MilligramsPerMeterInOneKilogramPerMeter => 1e6;

        protected override double GramsPerCentimeterInOneKilogramPerMeter => 1e1;
        protected override double GramsPerMeterInOneKilogramPerMeter => 1e3;
        protected override double GramsPerMillimeterInOneKilogramPerMeter => 1;

        protected override double KilogramsPerCentimeterInOneKilogramPerMeter => 1e-2;
        protected override double KilogramsPerMeterInOneKilogramPerMeter => 1;
        protected override double KilogramsPerMillimeterInOneKilogramPerMeter => 1e-3;

        protected override double PoundsPerInchInOneKilogramPerMeter => 5.599741459E-02;

        protected override double PoundsPerFootInOneKilogramPerMeter => 6.71968975e-1;

        [Fact]
        public void LinearDensityDividedByAreaEqualsDensity()
        {
            Density density = LinearDensity.FromGramsPerCentimeter(10) / Area.FromSquareCentimeters(2);
            Assert.Equal(5, density.GramsPerCubicCentimeter);
        }

        [Fact]
        public void LinearDensityDividedByDensityEqualsArea()
        {
            Area area = LinearDensity.FromGramsPerCentimeter(10) / Density.FromGramsPerCubicCentimeter(2);
            Assert.Equal(5, area.SquareCentimeters);
        }

        [Fact]
        public void LinearDensityTimesLengthEqualsMass()
        {
            Mass mass = LinearDensity.FromGramsPerCentimeter(10) * Length.FromCentimeters(2);
            Assert.Equal(20, mass.Grams);
        }
    }
}
