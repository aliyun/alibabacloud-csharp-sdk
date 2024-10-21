// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> was not returned, it indicates that no additional results exist.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
        /// <para>A list of multicast groups.</para>
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
            /// <para>Indicates whether the multicast resource is a multicast member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GroupMember")]
            [Validation(Required=false)]
            public bool? GroupMember { get; set; }

            /// <summary>
            /// <para>Indicates whether the multicast resource is a multicast source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("GroupSource")]
            [Validation(Required=false)]
            public bool? GroupSource { get; set; }

            /// <summary>
            /// <para>The type of the multicast source.</para>
            /// <para>If the value is <b>Static</b>, the multicast source is manually specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Static</para>
            /// </summary>
            [NameInMap("MemberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            /// <summary>
            /// <para>The ID of the ENI, which is a multicast resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-p0weuda3lszwzjly****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The ID of the multicast domain associated with the multicast resource that is deployed across regions.</para>
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
            /// <para>The ID of the Alibaba Cloud account to which the multicast resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253460731706911258</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the multicast resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b>: The multicast resource is in a VPC.</description></item>
            /// <item><description><b>TR</b>: The multicast resource is deployed across regions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The type of the multicast member.</para>
            /// <para>If the value is <b>Static</b>, the multicast member is manually specified.</para>
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
            /// <item><description><b>Registering</b>: being created</description></item>
            /// <item><description><b>Registered</b>: available</description></item>
            /// <item><description><b>Deregistering</b>: being deleted</description></item>
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
