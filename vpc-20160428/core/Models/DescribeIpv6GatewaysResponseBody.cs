// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6GatewaysResponseBody : TeaModel {
        /// <summary>
        /// The information about the IPv6 gateway.
        /// </summary>
        [NameInMap("Ipv6Gateways")]
        [Validation(Required=false)]
        public DescribeIpv6GatewaysResponseBodyIpv6Gateways Ipv6Gateways { get; set; }
        public class DescribeIpv6GatewaysResponseBodyIpv6Gateways : TeaModel {
            [NameInMap("Ipv6Gateway")]
            [Validation(Required=false)]
            public List<DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6Gateway> Ipv6Gateway { get; set; }
            public class DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6Gateway : TeaModel {
                /// <summary>
                /// The status of the IPv6 gateway. Valid values:
                /// 
                /// *   **Normal**
                /// *   **FinancialLocked**
                /// *   **SecurityLocked**
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The time when the IPv6 gateway was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the IPv6 gateway.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the IPv6 gateway expires.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The billing method of the IPv6 gateway.
                /// 
                /// Only **PostPaid** may be returned, which indicates that the IPv6 gateway uses the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The ID of the IPv6 gateway.
                /// </summary>
                [NameInMap("Ipv6GatewayId")]
                [Validation(Required=false)]
                public string Ipv6GatewayId { get; set; }

                /// <summary>
                /// The name of the IPv6 gateway.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the region in which the IPv6 gateway is deployed.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The status of the IPv6 gateway. Valid values:
                /// 
                /// *   **Pending**
                /// *   **Available**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The information about the tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6GatewayTags Tags { get; set; }
                public class DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6GatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6GatewayTagsTag> Tag { get; set; }
                    public class DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6GatewayTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the VPC to which the IPv6 gateway belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
