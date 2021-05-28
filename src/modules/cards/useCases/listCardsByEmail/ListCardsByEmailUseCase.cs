using System;
using System.Collections.Generic;

namespace Card.ListCards.Services {
  public class ListCardsByEmailUseCase {
    private static ICardsRepository _cardsRepository;
    public ListCardsByEmailUseCase(ICardsRepository cardsRepository) {
      _cardsRepository = cardsRepository;
    }
    public List<Card> execute(string email) {
      List<Card> cards = _cardsRepository.listCardsByEmail(email);

      return cards;
    }
  }
}