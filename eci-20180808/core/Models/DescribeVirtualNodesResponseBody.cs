// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeVirtualNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d78f2dd8-5979-42fe-****-b16db43be5bc</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C9B9917-ED22-50D5-ADE6-9FA9D58AD05F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of virtual nodes that were queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The virtual nodes that were queried.</para>
        /// </summary>
        [NameInMap("VirtualNodes")]
        [Validation(Required=false)]
        public List<DescribeVirtualNodesResponseBodyVirtualNodes> VirtualNodes { get; set; }
        public class DescribeVirtualNodesResponseBodyVirtualNodes : TeaModel {
            /// <summary>
            /// <para>The time when the virtual node was created. The time follows the RFC 3339 standard and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-08T15:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The events about the virtual node.</para>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeVirtualNodesResponseBodyVirtualNodesEvents> Events { get; set; }
            public class DescribeVirtualNodesResponseBodyVirtualNodesEvents : TeaModel {
                /// <summary>
                /// <para>The number of events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The time when the event started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-08T02:24:48Z</para>
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// <para>The time when the event ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-08T02:24:52Z</para>
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// <para>The message of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Successfully</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The name of the object to which the event belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The name of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Created</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The type of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal</description></item>
                /// <item><description>Warning</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The public IP address of the virtual node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the virtual node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.19.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the virtual node resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the virtual node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-uf66jeqopgqa9hdn****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the virtual node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending</description></item>
            /// <item><description>Ready</description></item>
            /// <item><description>Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags that are bound to the virtual node.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeVirtualNodesResponseBodyVirtualNodesTags> Tags { get; set; }
            public class DescribeVirtualNodesResponseBodyVirtualNodesTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the virtual node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vnd-2ze960zkdqrldeaw****</para>
            /// </summary>
            [NameInMap("VirtualNodeId")]
            [Validation(Required=false)]
            public string VirtualNodeId { get; set; }

            /// <summary>
            /// <para>The name of the virtual node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testNode</para>
            /// </summary>
            [NameInMap("VirtualNodeName")]
            [Validation(Required=false)]
            public string VirtualNodeName { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the virtual node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeeyaaxlkq9sppl****</para>
            /// </summary>
            [NameInMap("VirtualNodeSecurityGroupId")]
            [Validation(Required=false)]
            public string VirtualNodeSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch with which the virtual node is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze23nqzig8inprou****</para>
            /// </summary>
            [NameInMap("VirtualNodeVSwitchId")]
            [Validation(Required=false)]
            public string VirtualNodeVSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the virtual node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-1vzjjflab6wvjox****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
