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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of multicast group information.</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastGroups")]
        [Validation(Required=false)]
        public List<ListTransitRouterMulticastGroupsResponseBodyTransitRouterMulticastGroups> TransitRouterMulticastGroups { get; set; }
        public class ListTransitRouterMulticastGroupsResponseBodyTransitRouterMulticastGroups : TeaModel {
            /// <summary>
            /// <para>The IP address of the multicast group to which the multicast resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>239.XX.XX.2</para>
            /// </summary>
            [NameInMap("GroupIpAddress")]
            [Validation(Required=false)]
            public string GroupIpAddress { get; set; }

            /// <summary>
            /// <para>Indicates whether the current multicast resource is a multicast member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The multicast resource is a multicast member.</description></item>
            /// <item><description><b>false</b>: The multicast resource is not a multicast member.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GroupMember")]
            [Validation(Required=false)]
            public bool? GroupMember { get; set; }

            /// <summary>
            /// <para>Indicates whether the current multicast resource is a multicast source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The multicast resource is a multicast source.</description></item>
            /// <item><description><b>false</b>: The multicast resource is not a multicast source.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("GroupSource")]
            [Validation(Required=false)]
            public bool? GroupSource { get; set; }

            /// <summary>
            /// <para>The type of the multicast member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Static</b>: The multicast member is manually specified.</para>
            /// </description></item>
            /// <item><description><para><b>IGMPv2</b>: The multicast member dynamically joined the multicast group through the IGMP protocol.</para>
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
            /// <para>The elastic network interface (ENI) ID, which is the multicast resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-p0weuda3lszwzjly****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The ID of the multicast domain associated with the cross-region multicast resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-mcast-domain-91wpg6wbhchjeq****</para>
            /// </summary>
            [NameInMap("PeerTransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string PeerTransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// <para>The resource ID associated with the multicast resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-p0w9alkte4w2htrqe****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the multicast resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11081188765****</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the multicast resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b>: The multicast resource is a resource in a VPC.</description></item>
            /// <item><description><b>TR</b>: The multicast resource is a cross-region resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The type of the multicast source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Static</b>: The multicast source is manually specified.</para>
            /// </description></item>
            /// <item><description><para><b>IGMPv2</b>: The multicast source dynamically joined the multicast group through the IGMP protocol.</para>
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
            /// <para>The status of the multicast resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Registering</b>: being created.</description></item>
            /// <item><description><b>Registered</b>: available.</description></item>
            /// <item><description><b>Deregistering</b>: being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Registered</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The network instance connection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-g3kz2k3u76amsk****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The multicast domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-mcast-domain-kx0vk0v7fz8kx4****</para>
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the multicast resource belongs.</para>
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
