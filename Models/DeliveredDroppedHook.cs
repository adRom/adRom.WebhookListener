﻿using System;

namespace adRom.WebhookListener.Models
{
    public class DeliveredDroppedHook
    {
        public string SenderDomain { get; set; }
        public string Recipient { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Delivered { get; set; }
        public string Reason { get; set; }
        public string TransactionId { get; set; }
        public string IpAddress { get; set; }
    }
}