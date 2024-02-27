// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteTableListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the route table.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The type of the cloud resource with which the route table is associated. Valid values:
        /// 
        /// *   **VSwitch**: vSwitch
        /// *   **Gateway**: IPv4 gateway
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the vRouter to which the route table belongs.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The description of the route table.
        /// </summary>
        [NameInMap("RouterTableList")]
        [Validation(Required=false)]
        public DescribeRouteTableListResponseBodyRouterTableList RouterTableList { get; set; }
        public class DescribeRouteTableListResponseBodyRouterTableList : TeaModel {
            [NameInMap("RouterTableListType")]
            [Validation(Required=false)]
            public List<DescribeRouteTableListResponseBodyRouterTableListRouterTableListType> RouterTableListType { get; set; }
            public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListType : TeaModel {
                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("AssociateType")]
                [Validation(Required=false)]
                public string AssociateType { get; set; }

                /// <summary>
                /// The type of the router to which the route table belongs. Valid values:
                /// 
                /// *   **VRouter**
                /// *   **VBR**
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The information about the vSwitches.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The detailed information about the IPv4 gateway.
                /// </summary>
                [NameInMap("GatewayIds")]
                [Validation(Required=false)]
                public DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeGatewayIds GatewayIds { get; set; }
                public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeGatewayIds : TeaModel {
                    [NameInMap("GatewayIds")]
                    [Validation(Required=false)]
                    public List<string> GatewayIds { get; set; }

                }

                /// <summary>
                /// The value of tag N added to the resource.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// The detailed information about the IPv4 gateway.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Whether to receive the propagation routes. Valid Values:
                /// 
                /// *   **True**: The propagation route is received.
                /// 
                /// *   **False**: The propagation route is not received.
                /// </summary>
                [NameInMap("RoutePropagationEnable")]
                [Validation(Required=false)]
                public bool? RoutePropagationEnable { get; set; }

                /// <summary>
                /// The key of tag N added to the resource.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// The name of the route table.
                /// </summary>
                [NameInMap("RouteTableName")]
                [Validation(Required=false)]
                public string RouteTableName { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("RouteTableType")]
                [Validation(Required=false)]
                public string RouteTableType { get; set; }

                /// <summary>
                /// The tag added to the route table.
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// The detailed information about the IPv4 gateway.
                /// </summary>
                [NameInMap("RouterType")]
                [Validation(Required=false)]
                public string RouterType { get; set; }

                /// <summary>
                /// The name of the route table.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeTags Tags { get; set; }
                public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeTagsTag> Tag { get; set; }
                    public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeTagsTag : TeaModel {
                        /// <summary>
                        /// The key of tag N to add to the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.
                        /// 
                        /// The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of tag N to add to the resource. You can specify up to 20 tag values. The tag value can be an empty string.
                        /// 
                        /// The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The vSwitch IDs.
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeVSwitchIds VSwitchIds { get; set; }
                public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }

                /// <summary>
                /// The ID of the resource group to which the route table belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the route table belongs.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
