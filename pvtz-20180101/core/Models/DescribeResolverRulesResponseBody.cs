// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverRulesResponseBody : TeaModel {
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
        /// <para>A10E03D7-808C-422D-9144-F8586C2E2297</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The forwarding rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeResolverRulesResponseBodyRules> Rules { get; set; }
        public class DescribeResolverRulesResponseBodyRules : TeaModel {
            [NameInMap("BindEdgeDnsClusters")]
            [Validation(Required=false)]
            public List<DescribeResolverRulesResponseBodyRulesBindEdgeDnsClusters> BindEdgeDnsClusters { get; set; }
            public class DescribeResolverRulesResponseBodyRulesBindEdgeDnsClusters : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("ClusterUserId")]
                [Validation(Required=false)]
                public long? ClusterUserId { get; set; }

            }

            /// <summary>
            /// <para>The VPCs associated with the forwarding rule.</para>
            /// </summary>
            [NameInMap("BindVpcs")]
            [Validation(Required=false)]
            public List<DescribeResolverRulesResponseBodyRulesBindVpcs> BindVpcs { get; set; }
            public class DescribeResolverRulesResponseBodyRulesBindVpcs : TeaModel {
                /// <summary>
                /// <para>The region ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the region to which the VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-1</para>
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// <para>The VPC ID. This ID uniquely identifies the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jl96awrjt75ezglc****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The VPC name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-name-test</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

                /// <summary>
                /// <para>The VPC type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>STANDARD: standard VPC</description></item>
                /// <item><description>EDS: Elastic Desktop Service (EDS) workspace VPC</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>STANDARD</para>
                /// </summary>
                [NameInMap("VpcType")]
                [Validation(Required=false)]
                public string VpcType { get; set; }

                /// <summary>
                /// <para>The user ID to which the VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>141339776561****</para>
                /// </summary>
                [NameInMap("VpcUserId")]
                [Validation(Required=false)]
                public string VpcUserId { get; set; }

            }

            /// <summary>
            /// <para>The time when the forwarding was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-13 10:51:44</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the forwarding rule was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594608704000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hr****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The endpoint name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>endpoint-test</para>
            /// </summary>
            [NameInMap("EndpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <para>The IP addresses and ports of the external DNS servers. Enter the IP addresses and ports of the destination servers to which the DNS requests are forwarded.</para>
            /// </summary>
            [NameInMap("ForwardIps")]
            [Validation(Required=false)]
            public List<DescribeResolverRulesResponseBodyRulesForwardIps> ForwardIps { get; set; }
            public class DescribeResolverRulesResponseBodyRulesForwardIps : TeaModel {
                /// <summary>
                /// <para>The IP address of the destination server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The port of the destination server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// <para>The ID of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hr****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>forward rule-test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PriorityForwardConfigs")]
            [Validation(Required=false)]
            public List<DescribeResolverRulesResponseBodyRulesPriorityForwardConfigs> PriorityForwardConfigs { get; set; }
            public class DescribeResolverRulesResponseBodyRulesPriorityForwardConfigs : TeaModel {
                [NameInMap("AlidnsServiceAddresses")]
                [Validation(Required=false)]
                public List<string> AlidnsServiceAddresses { get; set; }

                [NameInMap("CustomAddresses")]
                [Validation(Required=false)]
                public List<string> CustomAddresses { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The type of the forwarding rule.</para>
            /// <para>The parameter value can only be OUTBOUND, which indicates that Domain Name System (DNS) requests are forwarded to one or more external IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OUTBOUND</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the forwarding rule was last modified. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-13 10:51:44</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The time when the forwarding rule was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594608704000</para>
            /// </summary>
            [NameInMap("UpdateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

            /// <summary>
            /// <para>The zone for which you want to forward DNS requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
