using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Card.Services;
using Card.Error;

namespace Card.Controllers {
  public class RequestBody {
    public string email {get; set;}
  }

  [ApiController]
  [Route("/cards")]
  public class CreateCardController : ControllerBase {
    private static CreateCardUseCase _createCardUseCase;
    public CreateCardController(ICardsRepository cardsRepository) {
      _createCardUseCase = new CreateCardUseCase(cardsRepository);
    }

    [HttpPost]
    public object handle([FromBody] RequestBody request) {
      Card card = _createCardUseCase.execute(request.email);
      return StatusCode(201, card);
    }

  }
} 