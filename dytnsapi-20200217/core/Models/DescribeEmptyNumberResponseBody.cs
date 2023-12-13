// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribeEmptyNumberResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **OK**: The request is successful.
        /// *   **InvalidPhoneNumber.Check**: The phone number is invalid.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEmptyNumberResponseBodyData Data { get; set; }
        public class DescribeEmptyNumberResponseBodyData : TeaModel {
            /// <summary>
            /// The specified phone number.
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// The returned status for the queried phone number. Valid values:
            /// 
            /// *   **EMPTY**: The queried phone number is a nonexistent number.
            /// *   **NORMAL**: The queried phone number is valid.
            /// *   **SUSPECT_EMPTY**: The queried phone number is suspected to be a nonexistent number.
            /// *   **UNKNOWN**: The queried phone number is unknown.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The unique request ID. It is a common parameter and can be used to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
