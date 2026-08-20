// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A10E03D7-808C-422D-9144-F8586C2E2297</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of forwarding rules.</para>
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
            /// <para>The list of associated VPCs.</para>
            /// </summary>
            [NameInMap("BindVpcs")]
            [Validation(Required=false)]
            public List<DescribeResolverRulesResponseBodyRulesBindVpcs> BindVpcs { get; set; }
            public class DescribeResolverRulesResponseBodyRulesBindVpcs : TeaModel {
                /// <summary>
                /// <para>The ID of the region where the VPC resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the region where the VPC resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Ulanqab)</para>
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// <para>The unique ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jl96awrjt75ezglc****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-name-test</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

                /// <summary>
                /// <para>The type of the VPC. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>STANDARD: a standard VPC.</para>
                /// </description></item>
                /// <item><description><para>EDS: a workspace VPC of Elastic Desktop Service (EDS).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>STANDARD</para>
                /// </summary>
                [NameInMap("VpcType")]
                [Validation(Required=false)]
                public string VpcType { get; set; }

                /// <summary>
                /// <para>The user ID (UID) of the account to which the VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>141339776561****</para>
                /// </summary>
                [NameInMap("VpcUserId")]
                [Validation(Required=false)]
                public string VpcUserId { get; set; }

            }

            /// <summary>
            /// <para>The time when the rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-13 10:51:44</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594608704000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hr****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Endpoint-test</para>
            /// </summary>
            [NameInMap("EndpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <para>The IP addresses and ports of the destination servers in an external DNS system. DNS query traffic is forwarded to these servers.</para>
            /// </summary>
            [NameInMap("ForwardIps")]
            [Validation(Required=false)]
            public List<DescribeResolverRulesResponseBodyRulesForwardIps> ForwardIps { get; set; }
            public class DescribeResolverRulesResponseBodyRulesForwardIps : TeaModel {
                /// <summary>
                /// <para>The destination IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The port of the destination IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
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
            /// <para>Forwarding rule-test</para>
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
            /// <para>The type of the forwarding rule. Currently, only forwarding to an external IP address is supported. Valid value:</para>
            /// <para>OUTBOUND: Forwards DNS requests to an external IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OUTBOUND</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-13 10:51:44</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594608704000</para>
            /// </summary>
            [NameInMap("UpdateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

            /// <summary>
            /// <para>The domain name (zone) for which DNS requests are forwarded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
