using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyShop.WebUI.Tests.Mocks
{
    public class MockHttpContext : HttpContextBase
    {
        private MockResponse _response;
        private MockRequest _request;
        private HttpCookieCollection _cookies;
        private IPrincipal _fakeUser;

        public MockHttpContext()
        {
            _cookies = new HttpCookieCollection();
            _response = new MockResponse(_cookies);
            _request = new MockRequest(_cookies);
        }

        public override IPrincipal User
        {
            get
            {
                return this._fakeUser;
            }
            set
            {
                this._fakeUser = value;
            }
        }

        public override HttpRequestBase Request
        {
            get
            {
                return _request;
            }
        }

        public override HttpResponseBase Response
        {
            get
            {
                return _response;
            }
        }
    }

    public class MockResponse : HttpResponseBase
    {
        private readonly HttpCookieCollection cookies;

        public MockResponse(HttpCookieCollection cookies)
        {
            this.cookies = cookies;
        }

        public override HttpCookieCollection Cookies
        {
            get
            {
                return cookies;
            }
        }
    }

    public class MockRequest : HttpRequestBase
    {
        private readonly HttpCookieCollection cookies;

        public MockRequest(HttpCookieCollection cookies)
        {
            this.cookies = cookies;
        }

        public override HttpCookieCollection Cookies
        {
            get
            {
                return cookies;
            }
        }
    }

}
