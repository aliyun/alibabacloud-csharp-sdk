// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifyPhoneWithTokenResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   If OK is returned, the request is successful.
        /// *   For more information about other error codes, see [API response codes](~~85198~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("GateVerify")]
        [Validation(Required=false)]
        public VerifyPhoneWithTokenResponseBodyGateVerify GateVerify { get; set; }
        public class VerifyPhoneWithTokenResponseBodyGateVerify : TeaModel {
            /// <summary>
            /// The external ID.
            /// </summary>
            [NameInMap("VerifyId")]
            [Validation(Required=false)]
            public string VerifyId { get; set; }

            /// <summary>
            /// The verification results. Valid values:
            /// 
            /// *   PASS: The input phone number is consistent with the phone number used in HTML5 pages.
            /// *   REJECT: The input phone number is different from the phone number used in HTML5 pages.
            /// *   UNKNOWN: The system cannot judge whether the input phone number is consistent with the phone number used in HTML5 pages.
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

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
