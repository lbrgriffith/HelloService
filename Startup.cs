using Microsoft.Owin;
using Owin;
using System;

namespace HelloService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // New code: Add the error page middleware to the pipeline. 
#if DEBUG
            app.UseErrorPage();
#endif
            app.Run(context =>
            {
                // New code: Throw an exception for this URI path.
                if (context.Request.Path.Equals(new PathString("/fail")))
                {
                    throw new Exception("Random exception");
                }

                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
        }
    }
}
