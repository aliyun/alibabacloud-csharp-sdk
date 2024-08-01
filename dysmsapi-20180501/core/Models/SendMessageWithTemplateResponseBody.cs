// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class SendMessageWithTemplateResponseBody : TeaModel {
        /// <summary>
        /// The ID of the message.
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// The details about the mobile phone number of the recipient.
        /// </summary>
        [NameInMap("NumberDetail")]
        [Validation(Required=false)]
        public SendMessageWithTemplateResponseBodyNumberDetail NumberDetail { get; set; }
        public class SendMessageWithTemplateResponseBodyNumberDetail : TeaModel {
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
        /// The number of messages that incurred fees.
        /// </summary>
        [NameInMap("Segments")]
        [Validation(Required=false)]
        public string Segments { get; set; }

        /// <summary>
        /// The mobile phone number to which the message was sent. The dialing code was added to the beginning of the mobile phone number. Example: 861503871\\*\\*\\*\\*.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}
