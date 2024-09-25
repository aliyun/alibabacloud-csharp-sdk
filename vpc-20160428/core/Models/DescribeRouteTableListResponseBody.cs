// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteTableListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The type of the cloud resource with which the route table is associated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VSwitch</b>: vSwitch</description></item>
        /// <item><description><b>Gateway</b>: IPv4 gateway</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the vRouter to which the route table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC668356-BCB4-42FD-9BC3-FA2B2E04B634</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The description of the route table.</para>
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
                /// <para>The tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VSwitch</para>
                /// </summary>
                [NameInMap("AssociateType")]
                [Validation(Required=false)]
                public string AssociateType { get; set; }

                /// <summary>
                /// <para>The type of the router to which the route table belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>VRouter</b></description></item>
                /// <item><description><b>VBR</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-22T10:40:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The information about the vSwitches.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is Route Table.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The detailed information about the IPv4 gateway.</para>
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
                /// <para>The value of tag N added to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>253460731706911258</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The detailed information about the IPv4 gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Whether to receive the propagation routes. Valid Values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>True</b>: The propagation route is received.</para>
                /// </description></item>
                /// <item><description><para><b>False</b>: The propagation route is not received.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RoutePropagationEnable")]
                [Validation(Required=false)]
                public bool? RoutePropagationEnable { get; set; }

                /// <summary>
                /// <para>The key of tag N added to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vtb-bp145q7glnuzdvzu2****</para>
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// <para>The name of the route table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doctest</para>
                /// </summary>
                [NameInMap("RouteTableName")]
                [Validation(Required=false)]
                public string RouteTableName { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("RouteTableType")]
                [Validation(Required=false)]
                public string RouteTableType { get; set; }

                /// <summary>
                /// <para>The tag added to the route table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vrt-bp1lhl0taikrteen8****</para>
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// <para>The detailed information about the IPv4 gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VRouter</para>
                /// </summary>
                [NameInMap("RouterType")]
                [Validation(Required=false)]
                public string RouterType { get; set; }

                /// <summary>
                /// <para>The name of the route table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags.</para>
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
                        /// <para>The key of tag N to add to the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
                        /// <para>The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>type</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N to add to the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
                        /// <para>The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ingress</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The vSwitch IDs.</para>
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
                /// <para>The ID of the resource group to which the route table belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp15zckdt37pq72****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the route table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
