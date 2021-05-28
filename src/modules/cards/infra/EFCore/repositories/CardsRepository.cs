using System;
using System.Linq;
using System.Collections.Generic;
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
        card_number = card_number,
        created_at = DateTime.Now
      };

      repository.Add(card);
      repository.SaveChanges();

      return card;
    }

    public List<Card> listCardsByEmail(string email) {
      List<Card> cards = repository
      .Cards.Where(c => c.email == email)
      .OrderBy(c => c.created_at)
      .ToList();

      return cards;
    }
  }
}