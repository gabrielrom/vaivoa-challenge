using System;
using Card.Error;

namespace Card.Services {
  public class CreateCardUseCase {
    private static ICardsRepository _cardsRepository;
    public CreateCardUseCase(ICardsRepository cardsRepository) {
      _cardsRepository = cardsRepository;
    }

    private static string generateCreditCardNumber () {
      Random rnd = new Random();

      string creditCardNumber = "";
      
      for(int i = 1; i <= 4; i++) {
        creditCardNumber += Convert.ToString(rnd.Next(1000, 9999));
      }

      return creditCardNumber;
    }
    public Card execute(string email) {
      string[] emailSplited = email.Split('@');

      if (String.IsNullOrEmpty(email)) {
        throw new AppError("You cannot create a credit card number without an email!");
      } else if (!email.Contains('@') || String.IsNullOrEmpty(emailSplited[1]) || !email.Contains(".com")) {
        throw new AppError("This email is invalid!");
      }
      
      string creditCardNumber = generateCreditCardNumber();

      Card card = _cardsRepository.create(email, creditCardNumber);

      return card;
    }
  }
}