using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Payment")]
        Pending,
        [EnumMember(Value = "Payment Received")]
        PaymentReceived,
        [EnumMember(Value = "Payment Failed")]
        PaymentFailed
    }
}