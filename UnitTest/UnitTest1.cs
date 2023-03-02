using System;
using System.Net;
using System.Net.Http;
using Implementation;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using Moq;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void GivenCallingHttpHandler_WhenResponseIsOk_ShouldReturnStringWithValueOfOk()
        {
            var mock = new Mock<IHttpHandler>();
            mock.Setup(t => t.Send("", "")).Returns(new HttpResponseMessage(HttpStatusCode.OK));
            var requester = new Requester(mock.Object);
            var result = requester.SendDummyRequest();
            Assert.Equal("Ok", result);
        }

        [Fact]
        public void GivenCallingHttpHandler_WhenResponseIsBadRequest_ShouldReturnStringWithValueOfNotOk()
        {
            var mock = new Mock<IHttpHandler>();
            mock.Setup(t => t.Send("", "")).Returns(new HttpResponseMessage(HttpStatusCode.BadRequest));
            var requester = new Requester(mock.Object);
            var result = requester.SendDummyRequest();
            Assert.Equal("NotOk", result);
        }
    }
}

