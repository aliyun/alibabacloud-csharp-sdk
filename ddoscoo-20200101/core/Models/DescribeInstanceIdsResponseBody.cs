// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceIdsResponseBody : TeaModel {
        /// <summary>
        /// The ID, type, description, and IP version of the instance.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<DescribeInstanceIdsResponseBodyInstanceIds> InstanceIds { get; set; }
        public class DescribeInstanceIdsResponseBodyInstanceIds : TeaModel {
            /// <summary>
            /// The type of the instance. Valid values:
            /// 
            /// *   **0**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Insurance mitigation plan
            /// *   **1**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Unlimited mitigation plan
            /// *   **2**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the CMA mitigation plan
            /// *   **3**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Sec-CMA mitigation plan
            /// *   **9**: Anti-DDoS Proxy (Chinese Mainland) instance of the Profession mitigation plan
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public int? Edition { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

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
            /// *   **Ipv4**
            /// *   **Ipv6**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
