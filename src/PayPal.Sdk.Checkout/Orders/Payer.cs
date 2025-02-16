using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Orders;

/// <summary>
/// The customer who approves and pays for the order. The customer is also known as the payer.
/// </summary>
public class Payer
{
    /// <summary>
    /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
    /// </summary>
    [JsonPropertyName("address")]
    public AddressPortable AddressPortable { get; set; } = null!;

    /// <summary>
    /// The stand-alone date, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard `date_time` type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
    /// </summary>
    [JsonPropertyName("birth_date")]
    public string BirthDate { get; set; } = null!;

    /// <summary>
    /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
    /// </summary>
    [JsonPropertyName("email_address")]
    public string Email { get; set; } = null!;

    /// <summary>
    /// The name of the party.
    /// </summary>
    [JsonPropertyName("name")]
    public Name Name { get; set; } = null!;

    /// <summary>
    /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
    /// </summary>
    [JsonPropertyName("payer_id")]
    public string PayerId { get; set; } = null!;

    /// <summary>
    /// The phone information.
    /// </summary>
    [JsonPropertyName("phone")]
    public PhoneWithType PhoneWithType { get; set; } = null!;

    /// <summary>
    /// The tax ID of the customer. The customer is also known as the payer. Both `tax_id` and `tax_id_type` are required.
    /// </summary>
    [JsonPropertyName("tax_info")]
    public TaxInfo TaxInfo { get; set; } = null!;
}
