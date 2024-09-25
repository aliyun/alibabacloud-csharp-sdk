// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6GatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the IPv6 gateway.</para>
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
                /// <para>The status of the IPv6 gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>FinancialLocked</b></description></item>
                /// <item><description><b>SecurityLocked</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The time when the IPv6 gateway was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-20T14:51:23Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the IPv6 gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>descriptionforIPv6GW</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the IPv6 gateway expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-20T14:51:23Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The billing method of the IPv6 gateway.</para>
                /// <para>Only <b>PostPaid</b> may be returned, which indicates that the IPv6 gateway uses the pay-as-you-go billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The ID of the IPv6 gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6gw-hp3rwmtmfhgisipv6gw-hp3rwmtmfhgis****</para>
                /// </summary>
                [NameInMap("Ipv6GatewayId")]
                [Validation(Required=false)]
                public string Ipv6GatewayId { get; set; }

                /// <summary>
                /// <para>The name of the IPv6 gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6GW</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the IPv6 gateway is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-huhehaote</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The status of the IPv6 gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Pending</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The information about the tags.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceJoshua</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the VPC to which the IPv6 gateway belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-123sedrfswd23****</para>
                /// </summary>
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
