using System;
using Microsoft.AspNetCore.Mvc;

namespace Card {
  public class CardsRepository : ICardsRepository {
    private static CardContext repository;
    public CardsRepository([FromServices]CardContext context) {
      repository = context;
    }
    public Card create(string email, string card_number) {
      Card card = new Card() {
        id = Convert.ToString(Guid.NewGuid()),
        email = email,
        card_number = card_number
      };

      repository.Add(card);
      repository.SaveChanges();

      return card;
    }
  }
}