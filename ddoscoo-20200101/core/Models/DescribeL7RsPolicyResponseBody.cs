// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7RsPolicyResponseBody : TeaModel {
        /// <summary>
        /// The details about the parameters for back-to-origin processing.
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public List<DescribeL7RsPolicyResponseBodyAttributes> Attributes { get; set; }
        public class DescribeL7RsPolicyResponseBodyAttributes : TeaModel {
            /// <summary>
            /// The parameter for back-to-origin processing.
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public DescribeL7RsPolicyResponseBodyAttributesAttribute Attribute { get; set; }
            public class DescribeL7RsPolicyResponseBodyAttributesAttribute : TeaModel {
                /// <summary>
                /// The timeout period for a new connection. Valid values: **1** to **10**. Unit: seconds. Default value: **5**.
                /// </summary>
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public int? ConnectTimeout { get; set; }

                /// <summary>
                /// The expiration time of a connection, in seconds. If the number of failures at the origin server exceeds the **MaxFails** value, the address of the origin server is set to down and the expiration time is **FailTimeout**. The final value is the maximum value of **ConnectTimeout** and **FailTimeout**. Valid values: **1** to **3600**. Unit: seconds. Default value: **10**.
                /// </summary>
                [NameInMap("FailTimeout")]
                [Validation(Required=false)]
                public int? FailTimeout { get; set; }

                /// <summary>
                /// The maximum number of failures. This parameter is related to health check. Valid values: **1** to **10**. Unit: seconds. Default value: **3**.
                /// </summary>
                [NameInMap("MaxFails")]
                [Validation(Required=false)]
                public int? MaxFails { get; set; }

                /// <summary>
                /// The primary/secondary flag. Valid values:
                /// 
                /// *   **active**: primary
                /// *   **backup**: secondary
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The timeout period for a read connection. Valid values: **10** to **300**. Unit: seconds. Default value: **120**.
                /// </summary>
                [NameInMap("ReadTimeout")]
                [Validation(Required=false)]
                public int? ReadTimeout { get; set; }

                /// <summary>
                /// The timeout period for a write connection. Valid values: **10** to **300**. Unit: seconds. Default value: **120**.
                /// </summary>
                [NameInMap("SendTimeout")]
                [Validation(Required=false)]
                public int? SendTimeout { get; set; }

                /// <summary>
                /// The weight of the origin server. This parameter takes effect only when **ProxyMode** is set to **rr**.
                /// 
                /// Valid values: **1** to **100**. Default value: **100**. A server with a higher weight receives more requests.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// The address of the origin server.
            /// </summary>
            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

            /// <summary>
            /// The address type of the origin server. Valid values:
            /// 
            /// *   **0**: IP address
            /// *   **1**: domain name
            /// </summary>
            [NameInMap("RsType")]
            [Validation(Required=false)]
            public int? RsType { get; set; }

        }

        /// <summary>
        /// The scheduling algorithm for back-to-origin traffic. Valid values:
        /// 
        /// *   **ip_hash**: the IP hash algorithm. This algorithm is used to redirect the requests from the same IP address to the same origin server.
        /// *   **rr**: the round-robin algorithm. This algorithm is used to redirect requests to origin servers in turn.
        /// *   **least_time**: the least response time algorithm. This algorithm is used to minimize the latency when requests are forwarded from Anti-DDoS Pro or Anti-DDoS Premium instances to origin servers based on the intelligent DNS resolution feature.
        /// </summary>
        [NameInMap("ProxyMode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RsAttrRwTimeoutMax")]
        [Validation(Required=false)]
        public long? RsAttrRwTimeoutMax { get; set; }

        /// <summary>
        /// The back-to-origin retry switch. Valid values:
        /// 
        /// *   **1**: on
        /// *   **0**: off
        /// </summary>
        [NameInMap("UpstreamRetry")]
        [Validation(Required=false)]
        public int? UpstreamRetry { get; set; }

    }

}
