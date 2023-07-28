// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentHostsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// > The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the hosts.
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public DescribeMonitoringAgentHostsResponseBodyHosts Hosts { get; set; }
        public class DescribeMonitoringAgentHostsResponseBodyHosts : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<DescribeMonitoringAgentHostsResponseBodyHostsHost> Host { get; set; }
            public class DescribeMonitoringAgentHostsResponseBodyHostsHost : TeaModel {
                /// <summary>
                /// The version of the CloudMonitor agent.
                /// </summary>
                [NameInMap("AgentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// The elastic IP address (EIP) of the host.
                /// </summary>
                [NameInMap("EipAddress")]
                [Validation(Required=false)]
                public string EipAddress { get; set; }

                /// <summary>
                /// The ID of the EIP.
                /// </summary>
                [NameInMap("EipId")]
                [Validation(Required=false)]
                public string EipId { get; set; }

                /// <summary>
                /// The name of the host.
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The type of the ECS instance.
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// The IP address of the host.
                /// 
                /// > Multiple IP addresses are separated with commas (,).
                /// </summary>
                [NameInMap("IpGroup")]
                [Validation(Required=false)]
                public string IpGroup { get; set; }

                /// <summary>
                /// The IP address of the Network Address Translation (NAT) gateway.
                /// </summary>
                [NameInMap("NatIp")]
                [Validation(Required=false)]
                public string NatIp { get; set; }

                /// <summary>
                /// The network type.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The operating system.
                /// </summary>
                [NameInMap("OperatingSystem")]
                [Validation(Required=false)]
                public string OperatingSystem { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The serial number of the host. A host that is not provided by Alibaba Cloud has a serial number instead of an instance ID.
                /// 
                /// > This parameter can be used to accurately search for a monitored host.
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// Indicates whether the host is provided by Alibaba Cloud. Valid values:
                /// 
                /// *   true: The host is provided by Alibaba Cloud.
                /// *   false: The host is not provided by Alibaba Cloud.
                /// </summary>
                [NameInMap("isAliyunHost")]
                [Validation(Required=false)]
                public bool? IsAliyunHost { get; set; }

            }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The total number of returned pages.
        /// </summary>
        [NameInMap("PageTotal")]
        [Validation(Required=false)]
        public int? PageTotal { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
