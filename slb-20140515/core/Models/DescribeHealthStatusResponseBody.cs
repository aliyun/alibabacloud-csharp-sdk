// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// The list of backend servers.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public DescribeHealthStatusResponseBodyBackendServers BackendServers { get; set; }
        public class DescribeHealthStatusResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<DescribeHealthStatusResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class DescribeHealthStatusResponseBodyBackendServersBackendServer : TeaModel {
                /// <summary>
                /// The frontend port that is used by the CLB instance.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                /// <summary>
                /// The backend port that is used by the CLB instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The frontend protocol that is used by the CLB instance.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The health status of the backend server. Valid values:
                /// 
                /// *   **normal**: The backend server is healthy.
                /// *   **abnormal**: The backend server is unhealthy.
                /// *   **unavailable**: The health check is not complete.
                /// </summary>
                [NameInMap("ServerHealthStatus")]
                [Validation(Required=false)]
                public string ServerHealthStatus { get; set; }

                /// <summary>
                /// The ID of the Elastic Compute Service (ECS) instance or elastic network interface (ENI).
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// The IP address of the ECS instance.
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
