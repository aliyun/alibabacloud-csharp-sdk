// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceListResponseBody : TeaModel {
        /// <summary>
        /// The details about the Anti-DDoS Origin instances.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeInstanceListResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeInstanceListResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// The condition that triggers automatic association of the instance with an object.
            /// </summary>
            [NameInMap("AutoProtectCondition")]
            [Validation(Required=false)]
            public DescribeInstanceListResponseBodyInstanceListAutoProtectCondition AutoProtectCondition { get; set; }
            public class DescribeInstanceListResponseBodyInstanceListAutoProtectCondition : TeaModel {
                [NameInMap("Events")]
                [Validation(Required=false)]
                public List<string> Events { get; set; }

            }

            /// <summary>
            /// Indicates whether auto-renewal is enabled for the instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            /// <summary>
            /// The number of protected public IP addresses for which blackhole filtering is triggered.
            /// 
            /// >  You can call the [DeleteBlackhole](https://help.aliyun.com/document_detail/118692.html) operation to deactivate blackhole filtering for a protected IP address.
            /// </summary>
            [NameInMap("BlackholdingCount")]
            [Validation(Required=false)]
            public string BlackholdingCount { get; set; }

            /// <summary>
            /// The type of the instance.
            /// 
            /// *   **ddos_ddosorigin_public_cn**: Anti-DDoS Origin 2.0 (Pay-as-you-go) on the China site (aliyun.com)
            /// *   **ddos_ddosorigin_public_intl**: Anti-DDoS Origin 2.0 (Pay-as-you-go) on the International site (alibabacloud.com)
            /// </summary>
            [NameInMap("CommodityType")]
            [Validation(Required=false)]
            public string CommodityType { get; set; }

            /// <summary>
            /// The application scope of the instance.
            /// 
            /// *   **1**: The instance supports public IP addresses in all regions.
            /// *   **2**: The instance supports public IP addresses in regions in the Chinese mainland.
            /// *   **3**: The instance supports public IP addresses in regions outside the Chinese mainland.
            /// *   **4**: The instance supports public IP addresses in a region in or outside the Chinese mainland.
            /// </summary>
            [NameInMap("CoverageType")]
            [Validation(Required=false)]
            public int? CoverageType { get; set; }

            /// <summary>
            /// The time when the instance expires. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// The time when the instance was purchased. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The mitigation plan of the instance. Valid values:
            /// 
            /// *   **0**: the Professional mitigation plan
            /// *   **1**: the Enterprise mitigation plan
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The protocol type of the IP address asset that is protected by the instance. Valid values:
            /// 
            /// *   **Ipv4**
            /// *   **Ipv6**
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

            /// <summary>
            /// The type of the cloud service that is associated with the Anti-DDoS Origin instance By default, this parameter is not returned. If the Anti-DDoS Origin instance is created by using a different cloud service, the code of the cloud service is returned.
            /// 
            /// Valid values:
            /// 
            /// *   **gamebox**: The Anti-DDoS Origin instance is created by using Game Security Box.
            /// *   **eip**: The Anti-DDoS Origin instance is created by using an elastic IP address (EIP) for which Anti-DDoS (Enhanced Edition) is enabled.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The status of the instance. Valid values:
            /// 
            /// *   **1**: normal
            /// *   **2**: expired
            /// *   **3**: released
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of Anti-DDoS Origin instances.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
