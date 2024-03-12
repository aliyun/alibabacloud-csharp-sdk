// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20230101.Models
{
    public class GetPhoneNumberIdentificationUrlResponseBody : TeaModel {
        /// <summary>
        /// The return code. Valid values:
        /// 
        /// *   **OK**: The request is successful.
        /// *   **IdentificationNotAvailable**: The verification system does not support the phone number that corresponds to the IP address.
        /// *   **MobileNumberIllegal**: The format of the phone number is invalid.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPhoneNumberIdentificationUrlResponseBodyData Data { get; set; }
        public class GetPhoneNumberIdentificationUrlResponseBodyData : TeaModel {
            /// <summary>
            /// The verification URL.
            /// </summary>
            [NameInMap("IdentificationUrl")]
            [Validation(Required=false)]
            public string IdentificationUrl { get; set; }

            /// <summary>
            /// The session ID.
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

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
