// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeVirtualNodesResponseBody : TeaModel {
        /// <summary>
        /// The token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of virtual nodes that were queried.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The virtual nodes that were queried.
        /// </summary>
        [NameInMap("VirtualNodes")]
        [Validation(Required=false)]
        public List<DescribeVirtualNodesResponseBodyVirtualNodes> VirtualNodes { get; set; }
        public class DescribeVirtualNodesResponseBodyVirtualNodes : TeaModel {
            /// <summary>
            /// The time when the virtual node was created. The time follows the RFC 3339 standard and is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The events about the virtual node.
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeVirtualNodesResponseBodyVirtualNodesEvents> Events { get; set; }
            public class DescribeVirtualNodesResponseBodyVirtualNodesEvents : TeaModel {
                /// <summary>
                /// The number of events.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The time when the event started.
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// The time when the event ended.
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// The message of the event.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The name of the object to which the event belongs.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The name of the event.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// The type of the event. Valid values:
                /// 
                /// *   Normal
                /// *   Warning
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The public IP address of the virtual node.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the virtual node.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The ID of the region in which the virtual node resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the virtual node belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The status of the virtual node. Valid values:
            /// 
            /// *   Pending
            /// *   Ready
            /// *   Failed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags that are bound to the virtual node.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeVirtualNodesResponseBodyVirtualNodesTags> Tags { get; set; }
            public class DescribeVirtualNodesResponseBodyVirtualNodesTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the virtual node.
            /// </summary>
            [NameInMap("VirtualNodeId")]
            [Validation(Required=false)]
            public string VirtualNodeId { get; set; }

            /// <summary>
            /// The name of the virtual node.
            /// </summary>
            [NameInMap("VirtualNodeName")]
            [Validation(Required=false)]
            public string VirtualNodeName { get; set; }

            /// <summary>
            /// The ID of the security group to which the virtual node belongs.
            /// </summary>
            [NameInMap("VirtualNodeSecurityGroupId")]
            [Validation(Required=false)]
            public string VirtualNodeSecurityGroupId { get; set; }

            /// <summary>
            /// The ID of the vSwitch with which the virtual node is associated.
            /// </summary>
            [NameInMap("VirtualNodeVSwitchId")]
            [Validation(Required=false)]
            public string VirtualNodeVSwitchId { get; set; }

            /// <summary>
            /// The ID of the VPC to which the virtual node belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
