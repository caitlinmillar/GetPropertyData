
using Moq;
using Microsoft.Extensions.Logging;
using GetPropertyData.Controllers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Routing;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

[TestFixture]
public class GetPropertyDetailsTests
{
    private Mock<ILogger<GetPropertyDetails>> _mockLogger;
    private GetPropertyDetails _controller;
    
    [SetUp]
    public void Setup()
    {
        _mockLogger = new Mock<ILogger<GetPropertyDetails>>();
        _controller = new GetPropertyDetails(_mockLogger.Object);
    }

    [Test]
    public void GetPropertyDataTest()
    {        // Arrange
        string Fname = "Mitchell";
        string Sname = "Marquez";
        string DOB = "08/04/1977";

        // Act
        var result = _controller.GetPropertyData(Fname, Sname, DOB);

        // Assert
        Assert.NotNull(result);
        Assert.IsInstanceOf<ActionResult<string>>(result);
    }
}