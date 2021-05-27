using System;

namespace Card.Services {
  public class CreateCardUseCase {
    private static ICardsRepository _cardsRepository;
    public CreateCardUseCase(ICardsRepository cardsRepository) {
      _cardsRepository = cardsRepository;
    }

    private static string generateCreditCarNumber () {
      Random rnd = new Random();

      string creditCardNumber = "";
      
      for(int i = 1; i <= 4; i++) {
        creditCardNumber += Convert.ToString(rnd.Next(1000, 9999));
      }

      return creditCardNumber;
    }
    public Card execute(string email) {
      string creditCardNumber = generateCreditCarNumber();

      Card card = _cardsRepository.create(email, creditCardNumber);

      return card;
    }
  }
}