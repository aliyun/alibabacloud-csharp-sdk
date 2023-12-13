// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class InvalidPhoneNumberFilterResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   **OK**: The request is successful.
        /// *   **MobileNumberIllegal**: The phone number is invalid.
        /// *   **EncyrptTypeIllegal**: The encryption type is invalid.
        /// *   **MobileNumberTypeNotMatch**: The phone number does not match the encryption type.
        /// *   **CarrierIllegal**: The carrier type is invalid.
        /// *   **AuthCodeNotExist**: The authorization code does not exist.
        /// *   **PortabilityNumberNotSupported**: Mobile number portability is not supported.
        /// *   **Unknown**: An unknown exception occurred.
        /// *   **AuthCodeAndApiNotMatch**: A system exception occurred.
        /// *   **AuthCodeAndApiNotMatch**: The authorization code does not match the API operation.
        /// *   **RequestFrequencyLimit**: Repeated queries for the same phone number at a high frequency within a short period of time are prohibited due to restrictions that are set by carriers. If this error code is returned, please try again later.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Details about the returned entries.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<InvalidPhoneNumberFilterResponseBodyData> Data { get; set; }
        public class InvalidPhoneNumberFilterResponseBodyData : TeaModel {
            /// <summary>
            /// The returned filter results.
            /// 
            /// *   **YES**: the valid phone number. The mappings are returned.
            /// *   **NO**: the invalid phone number. No mappings are returned.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

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
