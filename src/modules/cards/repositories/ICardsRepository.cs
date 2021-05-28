using System;
using System.Collections.Generic;

namespace Card {
  public interface ICardsRepository {
    Card create(string email, string card_number);
    List<Card> listCardsByEmail(string email);
  }
}