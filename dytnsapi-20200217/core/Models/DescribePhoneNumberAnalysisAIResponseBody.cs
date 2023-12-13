// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberAnalysisAIResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   OK: The request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePhoneNumberAnalysisAIResponseBodyData Data { get; set; }
        public class DescribePhoneNumberAnalysisAIResponseBodyData : TeaModel {
            /// <summary>
            /// The returned code.
            /// 
            /// *   YES: The specified phone number is valid.
            /// *   NO: The specified phone number is invalid.
            /// *   UNKNOWN: The specified phone number is unknown
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The specified phone number.
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

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
