// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no next page exists.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, the value is the token for the next page.</para>
        /// </description></item>
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
        /// <para>FB3C4A16-0933-5850-9D43-0C3EA37BCBFB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of multicast groups.</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastGroups")]
        [Validation(Required=false)]
        public List<ListTransitRouterMulticastGroupsResponseBodyTransitRouterMulticastGroups> TransitRouterMulticastGroups { get; set; }
        public class ListTransitRouterMulticastGroupsResponseBodyTransitRouterMulticastGroups : TeaModel {
            /// <summary>
            /// <para>The IP address of the multicast group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>239.XX.XX.2</para>
            /// </summary>
            [NameInMap("GroupIpAddress")]
            [Validation(Required=false)]
            public string GroupIpAddress { get; set; }

            /// <summary>
            /// <para>Indicates whether the multicast resource is a multicast member.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The resource is a multicast member.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The resource is not a multicast member.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GroupMember")]
            [Validation(Required=false)]
            public bool? GroupMember { get; set; }

            /// <summary>
            /// <para>Indicates whether the multicast resource is a multicast source.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The resource is a multicast source.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The resource is not a multicast source.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("GroupSource")]
            [Validation(Required=false)]
            public bool? GroupSource { get; set; }

            /// <summary>
            /// <para>The type of the multicast member.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Static</b>: The multicast member is manually specified.</para>
            /// </description></item>
            /// <item><description><para><b>IGMPv2</b>: The multicast member dynamically joins the multicast group based on Internet Group Management Protocol Version 2 (IGMPv2).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Static</para>
            /// </summary>
            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// <para>The ID of the ENI. The ENI is the multicast resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-p0weuda3lszwzjly****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The ID of the multicast domain that is associated with the cross-region multicast resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-mcast-domain-91wpg6wbhchjeq****</para>
            /// </summary>
            [NameInMap("PeerTransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string PeerTransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// <para>The ID of the resource associated with the multicast resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-p0w9alkte4w2htrqe****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the multicast resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11081188765****</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the multicast resource.</para>
            /// <list type="bullet">
            /// <item><description><para><b>VPC</b>: The multicast resource is in a VPC.</para>
            /// </description></item>
            /// <item><description><para><b>TR</b>: The multicast resource is a cross-region resource.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The type of the multicast source.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Static</b>: The multicast source is manually specified.</para>
            /// </description></item>
            /// <item><description><para><b>IGMPv2</b>: The multicast source dynamically joins the multicast group based on IGMPv2.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Static</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The status of the multicast resource.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Registering</b>: The resource is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Registered</b>: The resource is available.</para>
            /// </description></item>
            /// <item><description><para><b>Deregistering</b>: The resource is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Registered</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-g3kz2k3u76amsk****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The ID of the multicast domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-mcast-domain-kx0vk0v7fz8kx4****</para>
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-p0w9s2ig1jnwgrbzl****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

    }

}
