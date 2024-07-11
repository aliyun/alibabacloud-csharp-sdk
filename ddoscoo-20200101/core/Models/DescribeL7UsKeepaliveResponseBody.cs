// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7UsKeepaliveResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The value of the Back-to-origin Persistent Connections parameter.
        /// </summary>
        [NameInMap("RsKeepalive")]
        [Validation(Required=false)]
        public DescribeL7UsKeepaliveResponseBodyRsKeepalive RsKeepalive { get; set; }
        public class DescribeL7UsKeepaliveResponseBodyRsKeepalive : TeaModel {
            /// <summary>
            /// Indicates whether Back-to-origin Persistent Connections is turned on. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The number of requests that reuse persistent connections.
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public long? KeepaliveRequests { get; set; }

            /// <summary>
            /// The timeout period of idle persistent connections.
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public long? KeepaliveTimeout { get; set; }

        }

    }

}
