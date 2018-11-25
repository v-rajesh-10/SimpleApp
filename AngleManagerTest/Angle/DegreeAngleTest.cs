﻿using System;
using AngleManager.Angle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace AngleManagerTest.Angle
{
    [TestClass]
    public class DegreeAngleTest : AngleTestContext
    {
        #region Casting Tests
        [TestMethod]
        public void AngleInRadianExplicitCastedToAngleInDegree()
        {
            // Arrange
            var firstAngleInRadian = new RadianAngle(5);

            // Act
            DegreeAngle castedInstance = (DegreeAngle)firstAngleInRadian;

            // Assert
            castedInstance.Value.ShouldBe(ConvertToDegree(5));
        }
        #endregion
    }
}
