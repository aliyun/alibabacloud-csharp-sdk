// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworksResponseBody : TeaModel {
        /// <summary>
        /// <para>The VPCs.</para>
        /// </summary>
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public DescribeNetworksResponseBodyNetworks Networks { get; set; }
        public class DescribeNetworksResponseBodyNetworks : TeaModel {
            [NameInMap("Network")]
            [Validation(Required=false)]
            public List<DescribeNetworksResponseBodyNetworksNetwork> Network { get; set; }
            public class DescribeNetworksResponseBodyNetworksNetwork : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR block of the network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.xx.xx/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The timestamp when the instance was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-16T06:33:15Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The description of the network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the edge node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the gateway route table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rt-5*****tbs</para>
                /// </summary>
                [NameInMap("GatewayRouteTableId")]
                [Validation(Required=false)]
                public string GatewayRouteTableId { get; set; }

                /// <summary>
                /// <para>The ID of the network access control list (ACL).</para>
                /// 
                /// <b>Example:</b>
                /// <para>nacl-a2do9e413e0spxscd****</para>
                /// </summary>
                [NameInMap("NetworkAclId")]
                [Validation(Required=false)]
                public string NetworkAclId { get; set; }

                /// <summary>
                /// <para>The ID of the network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n-5***</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                /// <summary>
                /// <para>The name of the network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("NetworkName")]
                [Validation(Required=false)]
                public string NetworkName { get; set; }

                /// <summary>
                /// <para>The ID of the route table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rt-5*****pks</para>
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// <para>The IDs of the route tables.</para>
                /// </summary>
                [NameInMap("RouteTableIds")]
                [Validation(Required=false)]
                public DescribeNetworksResponseBodyNetworksNetworkRouteTableIds RouteTableIds { get; set; }
                public class DescribeNetworksResponseBodyNetworksNetworkRouteTableIds : TeaModel {
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public List<string> RouteTableId { get; set; }

                }

                /// <summary>
                /// <para>The route table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtb-5**</para>
                /// </summary>
                [NameInMap("RouterTableId")]
                [Validation(Required=false)]
                public string RouterTableId { get; set; }

                /// <summary>
                /// <para>The status of the network. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending</description></item>
                /// <item><description>Available</description></item>
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
                public DescribeNetworksResponseBodyNetworksNetworkTags Tags { get; set; }
                public class DescribeNetworksResponseBodyNetworksNetworkTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNetworksResponseBodyNetworksNetworkTagsTag> Tag { get; set; }
                    public class DescribeNetworksResponseBodyNetworksNetworkTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <term><b>Obsolete</b></term>
                        /// 
                        /// <summary>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagKey { get; set; }

                        /// <term><b>Obsolete</b></term>
                        /// 
                        /// <summary>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagValue { get; set; }

                        /// <summary>
                        /// <para>The bandwidth.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The list of vSwitches in the network.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public DescribeNetworksResponseBodyNetworksNetworkVSwitchIds VSwitchIds { get; set; }
                public class DescribeNetworksResponseBodyNetworksNetworkVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }

            }

        }

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
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
