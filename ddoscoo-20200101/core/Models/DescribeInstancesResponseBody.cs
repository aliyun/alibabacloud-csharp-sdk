// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of the instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// The time when the instance is created. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The overdue status of the instance. The value is fixed as **0**, which indicates that your Alibaba Cloud account does not have overdue payments. The instance supports only the subscription billing method.
            /// </summary>
            [NameInMap("DebtStatus")]
            [Validation(Required=false)]
            public int? DebtStatus { get; set; }

            /// <summary>
            /// The mitigation plan of the instance. Valid values:
            /// 
            /// *   **0**: Anti-DDoS Premium instance of the Insurance mitigation plan
            /// *   **1**: Anti-DDoS Premium instance of the Unlimited mitigation plan
            /// *   **2**: Anti-DDoS Premium instance of the MCA mitigation plan
            /// *   **9**: Anti-DDoS Pro instance of the Profession mitigation plan
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public int? Edition { get; set; }

            /// <summary>
            /// The forwarding status of the instance. Valid values:
            /// 
            /// *   **0**: The instance no longer forwards service traffic.
            /// *   **1**: The instance forwards service traffic as expected.
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public int? Enabled { get; set; }

            /// <summary>
            /// The time when the instance expires. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The IP address of the instance.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The IP address-based forwarding mode of the instance. Valid values:
            /// 
            /// *   **fnat**: Requests from IPv4 addresses are forwarded to origin servers that use IPv4 addresses and requests from IPv6 addresses are forwarded to origin servers that use IPv6 addresses.
            /// *   **v6tov4**: All requests are forwarded to origin servers that use IPv4 addresses.
            /// </summary>
            [NameInMap("IpMode")]
            [Validation(Required=false)]
            public string IpMode { get; set; }

            /// <summary>
            /// The IP version of the instance. Valid values:
            /// 
            /// *   **Ipv4**: IPv4
            /// *   **Ipv6**: IPv6
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// Indicates whether the 95th percentile metering method has been enabled for the instance. Valid values:
            /// 
            /// *   0: The 95th percentile metering method has not been enabled for the instance.
            /// *   1: The 95th percentile metering method has been enabled for the instance.
            /// </summary>
            [NameInMap("IsFirstOpenBw")]
            [Validation(Required=false)]
            public long? IsFirstOpenBw { get; set; }

            /// <summary>
            /// Indicates whether the metering method of the 95th percentile burstable QPS is enabled for the instance. Valid values:
            /// 
            /// - 0: no
            /// - 1: yes
            /// </summary>
            [NameInMap("IsFirstOpenQps")]
            [Validation(Required=false)]
            public long? IsFirstOpenQps { get; set; }

            /// <summary>
            /// The remarks of the instance.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The status of the instance. Valid values:
            /// 
            /// *   **1**: normal
            /// *   **2**: expired
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
