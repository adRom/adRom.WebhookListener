using System;

namespace adRom.WebhookListener.Models
{
    public class FeedbackLoopHook
    {
        public string SenderDomain { get; set; }
        public string Recipient { get; set; }
        public DateTime Timestamp { get; set; }
        public int MailingId { get; set; }
        public string TransactionId { get; set; }
    }
}