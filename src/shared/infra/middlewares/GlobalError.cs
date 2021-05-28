using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Card.Error;

namespace Card.Middleware {
  public class ErrorHandlerMiddleware {
    private readonly RequestDelegate _next;

    public ErrorHandlerMiddleware(RequestDelegate next) {
      _next = next;
    }

    public async Task Invoke(HttpContext context) {
      try {
        await _next(context);
      } catch (Exception error) {
        var response = context.Response;
        response.ContentType = "application/json";

        var result = "";

        switch (error) {
          case AppError e:
            response.StatusCode = e.statusCode;
            result = JsonSerializer.Serialize(new { message = e.messageError });

            break;
          default:
            response.StatusCode = (int)HttpStatusCode.InternalServerError;
            break;
        }
        
        await response.WriteAsync(result);
      }
    }
  }
}