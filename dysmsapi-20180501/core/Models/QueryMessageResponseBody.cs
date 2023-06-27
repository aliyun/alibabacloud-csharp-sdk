// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class QueryMessageResponseBody : TeaModel {
        /// <summary>
        /// The status code of the message.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The description of the status code.
        /// </summary>
        [NameInMap("ErrorDescription")]
        [Validation(Required=false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the message.
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// The details about the mobile phone number.
        /// </summary>
        [NameInMap("NumberDetail")]
        [Validation(Required=false)]
        public QueryMessageResponseBodyNumberDetail NumberDetail { get; set; }
        public class QueryMessageResponseBodyNumberDetail : TeaModel {
            /// <summary>
            /// The carrier that owns the mobile phone number.
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// The country to which the mobile phone number belongs.
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// The region to which the mobile phone number belongs.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// The time when the delivery receipt was received from the carrier.
        /// </summary>
        [NameInMap("ReceiveDate")]
        [Validation(Required=false)]
        public string ReceiveDate { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status code of the delivery request.
        /// </summary>
        [NameInMap("ResponseCode")]
        [Validation(Required=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// The description of the delivery request status.
        /// </summary>
        [NameInMap("ResponseDescription")]
        [Validation(Required=false)]
        public string ResponseDescription { get; set; }

        /// <summary>
        /// The time when the message was sent to the carrier.
        /// </summary>
        [NameInMap("SendDate")]
        [Validation(Required=false)]
        public string SendDate { get; set; }

        /// <summary>
        /// The delivery status of the message.
        /// 
        /// *   1: The message was sent.
        /// *   2: The message failed to be sent.
        /// *   3: The message is being sent.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The mobile phone number to which the message was sent.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}
