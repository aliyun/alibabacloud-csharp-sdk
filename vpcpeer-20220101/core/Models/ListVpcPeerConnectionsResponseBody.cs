// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcPeer20220101.Models
{
    public class ListVpcPeerConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent request is to be sent.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED39DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The details of the queried VPC peering connections.</para>
        /// </summary>
        [NameInMap("VpcPeerConnects")]
        [Validation(Required=false)]
        public List<ListVpcPeerConnectionsResponseBodyVpcPeerConnects> VpcPeerConnects { get; set; }
        public class ListVpcPeerConnectionsResponseBodyVpcPeerConnects : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the acceptor of the VPC peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25346073170691****</para>
            /// </summary>
            [NameInMap("AcceptingOwnerUid")]
            [Validation(Required=false)]
            public long? AcceptingOwnerUid { get; set; }

            /// <summary>
            /// <para>The region ID of the acceptor of the VPC peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("AcceptingRegionId")]
            [Validation(Required=false)]
            public string AcceptingRegionId { get; set; }

            /// <summary>
            /// <para>The details of the acceptor VPC-connected instance.</para>
            /// </summary>
            [NameInMap("AcceptingVpc")]
            [Validation(Required=false)]
            public ListVpcPeerConnectionsResponseBodyVpcPeerConnectsAcceptingVpc AcceptingVpc { get; set; }
            public class ListVpcPeerConnectionsResponseBodyVpcPeerConnectsAcceptingVpc : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR blocks of the acceptor.</para>
                /// </summary>
                [NameInMap("Ipv4Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv4Cidrs { get; set; }

                /// <summary>
                /// <para>The IPv6 CIDR blocks of the acceptor.</para>
                /// </summary>
                [NameInMap("Ipv6Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv6Cidrs { get; set; }

                /// <summary>
                /// <para>The instance ID of the acceptor VPC-connected instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1vzjkp2q1xgnind****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The bandwidth of the VPC peering connection. Unit: Mbit/s. The value must be an integer greater than 0.</para>
            /// <remarks>
            /// <para>A value of -1 indicates that no bandwidth limit is applied.</para>
            /// </remarks>
            /// <para>Default values:</para>
            /// <list type="bullet">
            /// <item><description>The default bandwidth of a cross-region VPC peering connection is 1024 Mbit/s.</description></item>
            /// <item><description>The default bandwidth of an intra-region VPC peering connection is -1 Mbit/s, which indicates that no bandwidth limit is applied.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The billing status of the VPC peering connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Normal.</description></item>
            /// <item><description><b>FinancialLocked</b>: Locked due to overdue payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            /// <summary>
            /// <para>The description of the VPC peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the jumbo frame feature is enabled for the VPC peering connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableJumboFrame")]
            [Validation(Required=false)]
            public bool? EnableJumboFrame { get; set; }

            /// <summary>
            /// <para>The time when the VPC peering connection was created. The time is displayed in UTC in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-24T09:02:36Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The expiration time of the VPC peering connection. The time is displayed in UTC in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
            /// <para>The specific expiration time is returned only when the <b>Status</b> of the VPC peering connection is <b>Accepting</b> or <b>Expired</b>. If the VPC peering connection is in other states, <b>null</b> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-01T09:02:36Z</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            /// <summary>
            /// <para>The time when the VPC peering connection was modified. The time is displayed in UTC in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-24T19:20:45Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcc-lnk0m24khwvtkm****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The link type of the VPC peering connection.</para>
            /// <para>Default values:</para>
            /// <list type="bullet">
            /// <item><description>The default link type of a cross-region VPC peering connection is Gold.</description></item>
            /// <item><description>The default link type of an intra-region VPC peering connection is empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Gold</para>
            /// </summary>
            [NameInMap("LinkType")]
            [Validation(Required=false)]
            public string LinkType { get; set; }

            /// <summary>
            /// <para>The associated cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SWAS</para>
            /// </summary>
            [NameInMap("ManagedService")]
            [Validation(Required=false)]
            public string ManagedService { get; set; }

            /// <summary>
            /// <para>The name of the VPC peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpcpeer</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the initiator of the VPC peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25346073170691****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>The region ID of the initiator of the VPC peering connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxazb4ph6aiy****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the VPC peering connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: Creating.</description></item>
            /// <item><description><b>Accepting</b>: Accepting.</description></item>
            /// <item><description><b>Updating</b>: Updating.</description></item>
            /// <item><description><b>Rejected</b>: Rejected.</description></item>
            /// <item><description><b>Expired</b>: Expired.</description></item>
            /// <item><description><b>Activated</b>: Activated.</description></item>
            /// <item><description><b>Deleting</b>: Deleting.</description></item>
            /// <item><description><b>Deleted</b>: Deleted.</description></item>
            /// </list>
            /// <para>For more information about the statuses of VPC peering connections, see <a href="https://help.aliyun.com/document_detail/418507.html">VPC peering connection overview</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Activated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVpcPeerConnectionsResponseBodyVpcPeerConnectsTags> Tags { get; set; }
            public class ListVpcPeerConnectionsResponseBodyVpcPeerConnectsTags : TeaModel {
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

            /// <summary>
            /// <para>The details of the initiator VPC-connected instance.</para>
            /// </summary>
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public ListVpcPeerConnectionsResponseBodyVpcPeerConnectsVpc Vpc { get; set; }
            public class ListVpcPeerConnectionsResponseBodyVpcPeerConnectsVpc : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR blocks of the initiator.</para>
                /// </summary>
                [NameInMap("Ipv4Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv4Cidrs { get; set; }

                /// <summary>
                /// <para>The IPv6 CIDR blocks of the initiator.</para>
                /// </summary>
                [NameInMap("Ipv6Cidrs")]
                [Validation(Required=false)]
                public List<string> Ipv6Cidrs { get; set; }

                /// <summary>
                /// <para>The instance ID of the initiator VPC-connected instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1gsk7h12ew7oegk****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

    }

}
