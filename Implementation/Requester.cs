using System;
namespace Implementation
{
    public class Requester
    {
        private readonly IHttpHandler _handler;

        public Requester(IHttpHandler handler)
        {
            _handler = handler;
        }

        public string SendDummyRequest()
        {
            var response = _handler.Send("", "");
            if (response.IsSuccessStatusCode)
            {
                return "Ok";
            }
            else
            {
                return "NotOk";
            }
            return "";
        }
    }
}

