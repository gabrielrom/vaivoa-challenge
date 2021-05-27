using System;

namespace Card {
  public interface ICardsRepository {
    Card create(string email, string card_number);
  }
}