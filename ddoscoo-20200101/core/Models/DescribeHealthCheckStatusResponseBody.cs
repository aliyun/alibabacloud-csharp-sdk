// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeHealthCheckStatusResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of the health status of the origin server.
        /// </summary>
        [NameInMap("HealthCheckStatus")]
        [Validation(Required=false)]
        public List<DescribeHealthCheckStatusResponseBodyHealthCheckStatus> HealthCheckStatus { get; set; }
        public class DescribeHealthCheckStatusResponseBodyHealthCheckStatus : TeaModel {
            /// <summary>
            /// The forwarding port.
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The forwarding protocol. Valid values:
            /// 
            /// *   **tcp**
            /// *   **udp**
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// An array that consists of the health states of the IP addresses of the origin server.
            /// </summary>
            [NameInMap("RealServerStatusList")]
            [Validation(Required=false)]
            public List<DescribeHealthCheckStatusResponseBodyHealthCheckStatusRealServerStatusList> RealServerStatusList { get; set; }
            public class DescribeHealthCheckStatusResponseBodyHealthCheckStatusRealServerStatusList : TeaModel {
                /// <summary>
                /// The IP address of the origin server.
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// The health state of the IP address. Valid values:
                /// 
                /// *   **normal**: healthy
                /// *   **abnormal**: unhealthy
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The health status of the origin server. Valid values:
            /// 
            /// *   **normal**: healthy
            /// *   **abnormal**: unhealthy
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
