// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNatGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the NAT gateways.</para>
        /// </summary>
        [NameInMap("NatGateways")]
        [Validation(Required=false)]
        public List<DescribeNatGatewaysResponseBodyNatGateways> NatGateways { get; set; }
        public class DescribeNatGatewaysResponseBodyNatGateways : TeaModel {
            /// <summary>
            /// <para>The time when the NAT gateway was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-22T07:03:32Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the ENS node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-xiangyang-5</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The list of elastic IP addresses (EIPs) that are associated with the Internet NAT gateway.</para>
            /// </summary>
            [NameInMap("IpLists")]
            [Validation(Required=false)]
            public List<DescribeNatGatewaysResponseBodyNatGatewaysIpLists> IpLists { get; set; }
            public class DescribeNatGatewaysResponseBodyNatGatewaysIpLists : TeaModel {
                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-50g****</para>
                /// </summary>
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                /// <summary>
                /// <para>The IP address of the EIP associated with the NAT gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.XX.XX.162</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The association between the EIP and the Internet NAT gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UsedByForwardTable</b>: The EIP is specified in a DNAT entry.</description></item>
                /// <item><description><b>UsedBySnatTable</b>: The EIP is specified in an SNAT entry.</description></item>
                /// <item><description><b>UsedByForwardSnatTable</b>: The EIP is specified in both an SNAT entry and a DNAT entry.</description></item>
                /// <item><description><b>Idle</b>: The EIP is not specified in a DNAT or SNAT entry.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Idle</para>
                /// </summary>
                [NameInMap("UsingStatus")]
                [Validation(Required=false)]
                public string UsingStatus { get; set; }

            }

            /// <summary>
            /// <para>The name of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nat-5t7nh1cfm6kxiszlttr38****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The ID of the network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5s2ml1olj0kzaws9n1yrj****</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <para>The type of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enat.default</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The status of the SNAT entry.</para>
            /// <list type="bullet">
            /// <item><description>Pending: The SNAT entry is being created or modified.</description></item>
            /// <item><description>Available: The SNAT entry is available.</description></item>
            /// <item><description>Deleting: The SNAT entry is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeNatGatewaysResponseBodyNatGatewaysTags> Tags { get; set; }
            public class DescribeNatGatewaysResponseBodyNatGatewaysTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <term><b>Obsolete</b></term>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                [Obsolete]
                public string TagKey { get; set; }

                /// <term><b>Obsolete</b></term>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                [Obsolete]
                public string TagValue { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-5szpp1os9m55myirbflfw****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2818A8F4-5E2B-5611-8732-5ACF7B677059</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of NAT gateways that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
