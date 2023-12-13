// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberEncryptResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other values indicate that the request failed. For more information, see [Error codes](~~109196~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Details about the returned entries.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<PhoneNumberEncryptResponseBodyData> Data { get; set; }
        public class PhoneNumberEncryptResponseBodyData : TeaModel {
            /// <summary>
            /// The encrypted phone number.
            /// </summary>
            [NameInMap("EncryptedNumber")]
            [Validation(Required=false)]
            public string EncryptedNumber { get; set; }

            /// <summary>
            /// The time when the phone number expires.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The original phone number.
            /// </summary>
            [NameInMap("OriginalNumber")]
            [Validation(Required=false)]
            public string OriginalNumber { get; set; }

        }

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

    }

}
