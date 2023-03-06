// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryChatappPhoneNumbersResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// 
        /// *   A value of OK indicates that the call is successful.
        /// *   Other values indicate that the call fails. For more information, see [Error codes](~~196974~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The list of phone numbers.
        /// </summary>
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public List<QueryChatappPhoneNumbersResponseBodyPhoneNumbers> PhoneNumbers { get; set; }
        public class QueryChatappPhoneNumbersResponseBodyPhoneNumbers : TeaModel {
            /// <summary>
            /// The verification status of the phone number.
            /// </summary>
            [NameInMap("CodeVerificationStatus")]
            [Validation(Required=false)]
            public string CodeVerificationStatus { get; set; }

            /// <summary>
            /// The maximum number of messages that can be sent to users by using the phone number.
            /// </summary>
            [NameInMap("MessagingLimitTier")]
            [Validation(Required=false)]
            public string MessagingLimitTier { get; set; }

            /// <summary>
            /// The status of the business name.
            /// </summary>
            [NameInMap("NameStatus")]
            [Validation(Required=false)]
            public string NameStatus { get; set; }

            /// <summary>
            /// The review status of the new business name.
            /// </summary>
            [NameInMap("NewNameStatus")]
            [Validation(Required=false)]
            public string NewNameStatus { get; set; }

            /// <summary>
            /// The phone number.
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// The quality rating of the phone number. Valid values:
            /// 
            /// *   **GREEN**
            /// *   **YELLOW**
            /// *   **RED**
            /// *   **UNKNOWN**
            /// </summary>
            [NameInMap("QualityRating")]
            [Validation(Required=false)]
            public string QualityRating { get; set; }

            /// <summary>
            /// The status of the phone number.
            /// 
            /// *   PENDING
            /// *   DELETED
            /// *   MIGRATED
            /// *   BANNED
            /// *   RESTRICTED
            /// *   RATE_LIMITED
            /// *   FLAGGED
            /// *   CONNECTED
            /// *   DISCONNECTED
            /// *   UNKNOWN
            /// *   UNVERIFIED
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The callback URL to which status reports are sent by using HTTP callbacks.
            /// </summary>
            [NameInMap("StatusCallbackUrl")]
            [Validation(Required=false)]
            public string StatusCallbackUrl { get; set; }

            /// <summary>
            /// The status report notification queue.
            /// </summary>
            [NameInMap("StatusQueue")]
            [Validation(Required=false)]
            public string StatusQueue { get; set; }

            /// <summary>
            /// The callback URL to which MO messages are sent by using HTTP callbacks.
            /// </summary>
            [NameInMap("UpCallbackUrl")]
            [Validation(Required=false)]
            public string UpCallbackUrl { get; set; }

            /// <summary>
            /// The mobile originated (MO) message notification queue.
            /// </summary>
            [NameInMap("UpQueue")]
            [Validation(Required=false)]
            public string UpQueue { get; set; }

            /// <summary>
            /// The name of the company with which the phone number is associated.
            /// </summary>
            [NameInMap("VerifiedName")]
            [Validation(Required=false)]
            public string VerifiedName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
