using System;

namespace Card.Error {
  public class AppError {
    public string messageError {get; private set;}
    public int statusCode { get; private set;}

    public AppError(string messageError, int statusCode = 400) {
      this.messageError = messageError;
      this.statusCode = statusCode;
    }
  }
}