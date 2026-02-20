namespace Iyzico3DSecure.DTOs;

public record PaymentRequestDto(
    string CardHolderName,
    string CardNumber,
    string ExpireYear,
    string ExpireMonth,
    string Cvc,
    decimal Price,
    string CallbackUrl
);
