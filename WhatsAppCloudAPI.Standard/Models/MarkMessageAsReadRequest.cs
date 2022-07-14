// <copyright file="MarkMessageAsReadRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace WhatsAppCloudAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using WhatsAppCloudAPI.Standard;
    using WhatsAppCloudAPI.Standard.Utilities;

    /// <summary>
    /// MarkMessageAsReadRequest.
    /// </summary>
    public class MarkMessageAsReadRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkMessageAsReadRequest"/> class.
        /// </summary>
        public MarkMessageAsReadRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkMessageAsReadRequest"/> class.
        /// </summary>
        /// <param name="messagingProduct">messaging_product.</param>
        /// <param name="status">status.</param>
        /// <param name="messageId">message_id.</param>
        public MarkMessageAsReadRequest(
            string messagingProduct,
            string status,
            string messageId)
        {
            this.MessagingProduct = messagingProduct;
            this.Status = status;
            this.MessageId = messageId;
        }

        /// <summary>
        /// Messaging service used for the request. Use 'whatsapp'.
        /// </summary>
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        /// <summary>
        /// A message's status. You can use this field to mark a message as read.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Id of the incoming message.
        /// </summary>
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MarkMessageAsReadRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is MarkMessageAsReadRequest other &&
                ((this.MessagingProduct == null && other.MessagingProduct == null) || (this.MessagingProduct?.Equals(other.MessagingProduct) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.MessageId == null && other.MessageId == null) || (this.MessageId?.Equals(other.MessageId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MessagingProduct = {(this.MessagingProduct == null ? "null" : this.MessagingProduct == string.Empty ? "" : this.MessagingProduct)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.MessageId = {(this.MessageId == null ? "null" : this.MessageId == string.Empty ? "" : this.MessageId)}");
        }
    }
}