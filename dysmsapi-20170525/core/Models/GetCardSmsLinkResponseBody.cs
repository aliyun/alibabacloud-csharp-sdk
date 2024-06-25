// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsLinkResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other values indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/101346.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCardSmsLinkResponseBodyData Data { get; set; }
        public class GetCardSmsLinkResponseBodyData : TeaModel {
            /// <summary>
            /// The mobile phone numbers that support card messages.
            /// </summary>
            [NameInMap("CardPhoneNumbers")]
            [Validation(Required=false)]
            public string CardPhoneNumbers { get; set; }

            /// <summary>
            /// The signatures must correspond to the mobile numbers and short URLs in sequence.
            /// </summary>
            [NameInMap("CardSignNames")]
            [Validation(Required=false)]
            public string CardSignNames { get; set; }

            /// <summary>
            /// The short URLs.
            /// </summary>
            [NameInMap("CardSmsLinks")]
            [Validation(Required=false)]
            public string CardSmsLinks { get; set; }

            /// <summary>
            /// The review status of the card message template.
            /// 
            /// *   **0**: pending approval
            /// *   **1**: approved
            /// *   **2**: rejected
            /// 
            /// > Unapproved card messages are rolled back.
            /// </summary>
            [NameInMap("CardTmpState")]
            [Validation(Required=false)]
            public int? CardTmpState { get; set; }

            /// <summary>
            /// The mobile phone numbers that do not support card messages.
            /// </summary>
            [NameInMap("NotMediaMobiles")]
            [Validation(Required=false)]
            public string NotMediaMobiles { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
