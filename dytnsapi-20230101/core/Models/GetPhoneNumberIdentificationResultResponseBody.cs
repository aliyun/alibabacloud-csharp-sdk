// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20230101.Models
{
    public class GetPhoneNumberIdentificationResultResponseBody : TeaModel {
        /// <summary>
        /// The return code. Valid values:
        /// 
        /// *   OK: The request is successful.
        /// *   NoIdentificationResult: No verification result is available or the verification failed.
        /// *   SessionNotValid: The session is invalid or expired.
        /// *   MobileNumberIllegal: The format of the phone number is invalid.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPhoneNumberIdentificationResultResponseBodyData Data { get; set; }
        public class GetPhoneNumberIdentificationResultResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the phone number passed the verification.
            /// </summary>
            [NameInMap("IsIdentified")]
            [Validation(Required=false)]
            public string IsIdentified { get; set; }

        }

        /// <summary>
        /// The description of the return code.
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
