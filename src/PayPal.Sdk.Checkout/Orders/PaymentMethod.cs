using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The customer and merchant payment preferences.
/// </summary>
public class PaymentMethod
{
    /// <summary>
    /// The merchant-preferred payment sources.
    /// </summary>
    [JsonPropertyName("payee_preferred")]
    public EPayeePreferred PayeePreferred { get; set; }

    /// <summary>
    /// The customer-selected payment method on the merchant site.
    /// </summary>
    [JsonPropertyName("payer_selected")]
    public EPayerSelected PayerSelected { get; set; }

    /// <summary>
    /// NACHA (the regulatory body governing the ACH network) requires that API callers (merchants, partners) obtain the consumer’s explicit authorization before initiating a transaction. To stay compliant, you’ll need to make sure that you retain a compliant authorization for each transaction that you originate to the ACH Network using this API. ACH transactions are categorized (using SEC codes) by how you capture authorization from the Receiver (the person whose bank account is being debited or credited). PayPal supports the following SEC codes.
    /// </summary>
    [JsonPropertyName("standard_entry_class_code")]
    public EStandardEntryClassCode StandardEntryClassCode { get; set; }
}
