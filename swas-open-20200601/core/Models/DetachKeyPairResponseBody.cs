// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DetachKeyPairResponseBody : TeaModel {
        /// <summary>
        /// The total number of simple application servers from which you fail to unbind key pairs.
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The request results.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DetachKeyPairResponseBodyResults> Results { get; set; }
        public class DetachKeyPairResponseBodyResults : TeaModel {
            /// <summary>
            /// The HTTP status code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The ID of the simple application server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The response message.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the key pair is unbound from the simple application server successfully. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public string Success { get; set; }

        }

        /// <summary>
        /// The total number of simple application servers from which the SSH key pair is unbound.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
