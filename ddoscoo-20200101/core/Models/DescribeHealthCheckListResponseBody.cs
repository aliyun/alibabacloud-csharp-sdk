// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeHealthCheckListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of information about the health check configuration.
        /// </summary>
        [NameInMap("HealthCheckList")]
        [Validation(Required=false)]
        public List<DescribeHealthCheckListResponseBodyHealthCheckList> HealthCheckList { get; set; }
        public class DescribeHealthCheckListResponseBodyHealthCheckList : TeaModel {
            /// <summary>
            /// The forwarding port.
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// The health check configuration.
            /// </summary>
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public DescribeHealthCheckListResponseBodyHealthCheckListHealthCheck HealthCheck { get; set; }
            public class DescribeHealthCheckListResponseBodyHealthCheckListHealthCheck : TeaModel {
                /// <summary>
                /// The domain name.
                /// 
                /// >  This parameter is returned only when the Layer 7 health check configuration is queried.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The number of consecutive failed health checks that must occur before a port is declared unhealthy. Valid values: **1** to **10**.
                /// </summary>
                [NameInMap("Down")]
                [Validation(Required=false)]
                public int? Down { get; set; }

                /// <summary>
                /// The interval at which checks are performed. Valid values: **1** to **30**. Unit: seconds.
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// The port that was checked.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The response timeout period. Valid values: **1** to **30**. Unit: seconds.
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// The type of the protocol. Valid values:
                /// 
                /// *   **tcp**: The Layer 4 health check configuration was queried.
                /// *   **http**: The Layer 7 health check configuration was queried.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The number of consecutive successful health checks that must occur before a port is declared healthy. Valid values: **1** to **10**.
                /// </summary>
                [NameInMap("Up")]
                [Validation(Required=false)]
                public int? Up { get; set; }

                /// <summary>
                /// The check path.
                /// 
                /// >  This parameter is returned only when the Layer 7 health check configuration is queried.
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

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

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
