using System.Diagnostics;

namespace MVC_01.CustomMiddlWare
{
    public class RequestTimingMiddlWare
    {
        private readonly RequestDelegate _next;
        public RequestTimingMiddlWare(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var watch = Stopwatch.StartNew();
            await _next(context);
            watch.Stop();
            Console.WriteLine($"[{context.Request.Path}] :: {watch.ElapsedMilliseconds} ms");
        }
    }
}
