using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Card.ListCards.Services;

namespace Card.ListCards.Controllers {
  public class Request {
    public string email {get; set;}
  }

  [ApiController]
  [Route("/cards")]
  public class ListCardsByEmailController : ControllerBase {
    private static ListCardsByEmailUseCase _listCardsUseCase;
    public ListCardsByEmailController(ICardsRepository cardsRepository) {
      _listCardsUseCase = new ListCardsByEmailUseCase(cardsRepository);
    }

    [HttpGet]
    public object handle([FromQuery] Request request) {
      var cards = _listCardsUseCase.execute(request.email);
      return StatusCode(200, cards);
    }

  }
} 