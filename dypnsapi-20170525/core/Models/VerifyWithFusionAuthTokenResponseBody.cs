// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifyWithFusionAuthTokenResponseBody : TeaModel {
        /// <summary>
        /// The response code. If OK is returned, the request is successful. Other values indicate that the request failed. For more information, see Error codes.
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
        /// The returned data.
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public VerifyWithFusionAuthTokenResponseBodyModel Model { get; set; }
        public class VerifyWithFusionAuthTokenResponseBodyModel : TeaModel {
            /// <summary>
            /// The phone number, which is returned when the verification is successful.
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// The phone number score, which is generated only after the phone number scoring node is enabled and the verification is successful. The higher the score, the more risky the phone number. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("PhoneScore")]
            [Validation(Required=false)]
            public long? PhoneScore { get; set; }

            /// <summary>
            /// The verification result. Valid values: PASS and UNKNOWN.
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        /// <summary>
        /// The request ID, which is used to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values: true false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
