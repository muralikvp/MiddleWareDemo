namespace MiddleWareDemo.MiddleWareServices
{
    public class CustomeMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello Dear Readers from custom Middleware!");
        }
    }

    public static class ClassWithNoImplementationMiddlewareExtensions
    {
        public static IApplicationBuilder UseClassWithNoImplementationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomeMiddleWare>();
        }
    }
}
