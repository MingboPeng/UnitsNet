﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
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

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions.NumberToAcElectricPotential
{
    public static class NumberToAcElectricPotentialExtensions
    {
        #region KilovoltAc

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double)"/>
        public static AcElectricPotential KilovoltAcs(this int value) => AcElectricPotential.FromKilovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double?)"/>
        public static AcElectricPotential? KilovoltAcs(this int? value) => AcElectricPotential.FromKilovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double)"/>
        public static AcElectricPotential KilovoltAcs(this long value) => AcElectricPotential.FromKilovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double?)"/>
        public static AcElectricPotential? KilovoltAcs(this long? value) => AcElectricPotential.FromKilovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double)"/>
        public static AcElectricPotential KilovoltAcs(this double value) => AcElectricPotential.FromKilovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double?)"/>
        public static AcElectricPotential? KilovoltAcs(this double? value) => AcElectricPotential.FromKilovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double)"/>
        public static AcElectricPotential KilovoltAcs(this float value) => AcElectricPotential.FromKilovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double?)"/>
        public static AcElectricPotential? KilovoltAcs(this float? value) => AcElectricPotential.FromKilovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double)"/>
        public static AcElectricPotential KilovoltAcs(this decimal value) => AcElectricPotential.FromKilovoltAcs(Convert.ToDouble(value));

        /// <inheritdoc cref="AcElectricPotential.FromKilovoltAcs(double?)"/>
        public static AcElectricPotential? KilovoltAcs(this decimal? value) => AcElectricPotential.FromKilovoltAcs(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegavoltAc

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double)"/>
        public static AcElectricPotential MegavoltAcs(this int value) => AcElectricPotential.FromMegavoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double?)"/>
        public static AcElectricPotential? MegavoltAcs(this int? value) => AcElectricPotential.FromMegavoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double)"/>
        public static AcElectricPotential MegavoltAcs(this long value) => AcElectricPotential.FromMegavoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double?)"/>
        public static AcElectricPotential? MegavoltAcs(this long? value) => AcElectricPotential.FromMegavoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double)"/>
        public static AcElectricPotential MegavoltAcs(this double value) => AcElectricPotential.FromMegavoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double?)"/>
        public static AcElectricPotential? MegavoltAcs(this double? value) => AcElectricPotential.FromMegavoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double)"/>
        public static AcElectricPotential MegavoltAcs(this float value) => AcElectricPotential.FromMegavoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double?)"/>
        public static AcElectricPotential? MegavoltAcs(this float? value) => AcElectricPotential.FromMegavoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double)"/>
        public static AcElectricPotential MegavoltAcs(this decimal value) => AcElectricPotential.FromMegavoltAcs(Convert.ToDouble(value));

        /// <inheritdoc cref="AcElectricPotential.FromMegavoltAcs(double?)"/>
        public static AcElectricPotential? MegavoltAcs(this decimal? value) => AcElectricPotential.FromMegavoltAcs(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrovoltAc

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double)"/>
        public static AcElectricPotential MicrovoltAcs(this int value) => AcElectricPotential.FromMicrovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double?)"/>
        public static AcElectricPotential? MicrovoltAcs(this int? value) => AcElectricPotential.FromMicrovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double)"/>
        public static AcElectricPotential MicrovoltAcs(this long value) => AcElectricPotential.FromMicrovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double?)"/>
        public static AcElectricPotential? MicrovoltAcs(this long? value) => AcElectricPotential.FromMicrovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double)"/>
        public static AcElectricPotential MicrovoltAcs(this double value) => AcElectricPotential.FromMicrovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double?)"/>
        public static AcElectricPotential? MicrovoltAcs(this double? value) => AcElectricPotential.FromMicrovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double)"/>
        public static AcElectricPotential MicrovoltAcs(this float value) => AcElectricPotential.FromMicrovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double?)"/>
        public static AcElectricPotential? MicrovoltAcs(this float? value) => AcElectricPotential.FromMicrovoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double)"/>
        public static AcElectricPotential MicrovoltAcs(this decimal value) => AcElectricPotential.FromMicrovoltAcs(Convert.ToDouble(value));

        /// <inheritdoc cref="AcElectricPotential.FromMicrovoltAcs(double?)"/>
        public static AcElectricPotential? MicrovoltAcs(this decimal? value) => AcElectricPotential.FromMicrovoltAcs(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillivoltAc

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double)"/>
        public static AcElectricPotential MillivoltAcs(this int value) => AcElectricPotential.FromMillivoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double?)"/>
        public static AcElectricPotential? MillivoltAcs(this int? value) => AcElectricPotential.FromMillivoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double)"/>
        public static AcElectricPotential MillivoltAcs(this long value) => AcElectricPotential.FromMillivoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double?)"/>
        public static AcElectricPotential? MillivoltAcs(this long? value) => AcElectricPotential.FromMillivoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double)"/>
        public static AcElectricPotential MillivoltAcs(this double value) => AcElectricPotential.FromMillivoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double?)"/>
        public static AcElectricPotential? MillivoltAcs(this double? value) => AcElectricPotential.FromMillivoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double)"/>
        public static AcElectricPotential MillivoltAcs(this float value) => AcElectricPotential.FromMillivoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double?)"/>
        public static AcElectricPotential? MillivoltAcs(this float? value) => AcElectricPotential.FromMillivoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double)"/>
        public static AcElectricPotential MillivoltAcs(this decimal value) => AcElectricPotential.FromMillivoltAcs(Convert.ToDouble(value));

        /// <inheritdoc cref="AcElectricPotential.FromMillivoltAcs(double?)"/>
        public static AcElectricPotential? MillivoltAcs(this decimal? value) => AcElectricPotential.FromMillivoltAcs(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region VoltAc

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double)"/>
        public static AcElectricPotential VoltAcs(this int value) => AcElectricPotential.FromVoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double?)"/>
        public static AcElectricPotential? VoltAcs(this int? value) => AcElectricPotential.FromVoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double)"/>
        public static AcElectricPotential VoltAcs(this long value) => AcElectricPotential.FromVoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double?)"/>
        public static AcElectricPotential? VoltAcs(this long? value) => AcElectricPotential.FromVoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double)"/>
        public static AcElectricPotential VoltAcs(this double value) => AcElectricPotential.FromVoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double?)"/>
        public static AcElectricPotential? VoltAcs(this double? value) => AcElectricPotential.FromVoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double)"/>
        public static AcElectricPotential VoltAcs(this float value) => AcElectricPotential.FromVoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double?)"/>
        public static AcElectricPotential? VoltAcs(this float? value) => AcElectricPotential.FromVoltAcs(value);

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double)"/>
        public static AcElectricPotential VoltAcs(this decimal value) => AcElectricPotential.FromVoltAcs(Convert.ToDouble(value));

        /// <inheritdoc cref="AcElectricPotential.FromVoltAcs(double?)"/>
        public static AcElectricPotential? VoltAcs(this decimal? value) => AcElectricPotential.FromVoltAcs(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
