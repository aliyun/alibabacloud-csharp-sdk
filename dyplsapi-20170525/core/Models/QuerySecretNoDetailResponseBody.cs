// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretNoDetailResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other status codes indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/109196.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The attributes of the phone number.
        /// </summary>
        [NameInMap("SecretNoInfoDTO")]
        [Validation(Required=false)]
        public QuerySecretNoDetailResponseBodySecretNoInfoDTO SecretNoInfoDTO { get; set; }
        public class QuerySecretNoDetailResponseBodySecretNoInfoDTO : TeaModel {
            /// <summary>
            /// The verification status of the phone number. Valid values:
            /// 
            /// *   **0**: The phone number is not verified.
            /// *   **1**: The phone number is verified.
            /// </summary>
            [NameInMap("CertifyStatus")]
            [Validation(Required=false)]
            public int? CertifyStatus { get; set; }

            /// <summary>
            /// The city.
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// The province.
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// The time when the phone number was purchased.
            /// </summary>
            [NameInMap("PurchaseTime")]
            [Validation(Required=false)]
            public string PurchaseTime { get; set; }

            /// <summary>
            /// The status of the phone number. Valid values:
            /// 
            /// *   **0**: The phone number is not bound to other phone numbers.
            /// *   **1**: The phone number is bound to other phone numbers.
            /// *   **2**: The phone number is locked.
            /// *   **3**: The phone number is frozen.
            /// </summary>
            [NameInMap("SecretStatus")]
            [Validation(Required=false)]
            public long? SecretStatus { get; set; }

            /// <summary>
            /// The carrier to which the phone number belongs. Valid values:
            /// 
            /// *   **1**: China Mobile
            /// *   **2**: China Unicom
            /// *   **3**: China Telecom
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public long? Vendor { get; set; }

        }

    }

}
