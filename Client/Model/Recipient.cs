﻿namespace SignifydCore.Client.Model
{
    public class Recipient
    {
        public string FullName { get; set; }
        public string ConfirmationEmail { get; set; }
        public string ConfirmationPhone { get; set; }
        public string Organization { get; set; }
        public Address DeliveryAddress { get; set; }
    }
}