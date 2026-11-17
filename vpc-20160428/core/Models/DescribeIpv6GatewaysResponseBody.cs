// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6GatewaysResponseBody : TeaModel {
        [NameInMap("Ipv6Gateways")]
        [Validation(Required=false)]
        public DescribeIpv6GatewaysResponseBodyIpv6Gateways Ipv6Gateways { get; set; }
        public class DescribeIpv6GatewaysResponseBodyIpv6Gateways : TeaModel {
            [NameInMap("Ipv6Gateway")]
            [Validation(Required=false)]
            public List<DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6Gateway> Ipv6Gateway { get; set; }
            public class DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6Gateway : TeaModel {
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("Ipv6GatewayId")]
                [Validation(Required=false)]
                public string Ipv6GatewayId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6GatewayTags Tags { get; set; }
                public class DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6GatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6GatewayTagsTag> Tag { get; set; }
                    public class DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6GatewayTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3A06196-3E7C-490D-8F39-CB4B5A0CE8AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
