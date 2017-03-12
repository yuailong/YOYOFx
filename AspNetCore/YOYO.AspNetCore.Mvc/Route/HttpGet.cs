using System;
using System.Threading;
using System.Threading.Tasks;
using YOYO.AspNetCore.Owin;
using System.Reflection;
using YOYO.AspNetCore.Mvc.ResponseProcessor;
using YOYO.AspNetCore.Mvc.Session;
using YOYO.Extensions.DI;

namespace YOYO.AspNetCore.Mvc.Route
{
    [AttributeUsage(AttributeTargets.Method)]
    public class HttpGetAttribute : HttpRouteAttribute
    {
        public HttpGetAttribute(string urlRole) : base(urlRole) { }


    }


}