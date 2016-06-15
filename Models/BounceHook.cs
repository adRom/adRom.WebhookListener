using System;

namespace adRom.WebhookListener.Models
{
    public class BounceHook
    {
        public string SenderDomain { get; set; }
        public string Recipient { get; set; }
        public DateTime Timestamp { get; set; }
        public string BounceType { get; set; }
        public string Reason { get; set; }
        public string TransactionId { get; set; }
    }
}