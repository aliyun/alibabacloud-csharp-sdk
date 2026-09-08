// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IP address of the multicast group.</para>
        /// <para>Each multicast group is identified by a multicast IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239.XX.XX.2</para>
        /// </summary>
        [NameInMap("GroupIpAddress")]
        [Validation(Required=false)]
        public string GroupIpAddress { get; set; }

        /// <summary>
        /// <para>Specifies whether to query multicast members. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: no.</description></item>
        /// <item><description><b>true</b>: yes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is used together with IsGroupSource.</para>
        /// <list type="bullet">
        /// <item><description>If neither parameter is configured, both multicast sources and members are queried by default.</description></item>
        /// <item><description>If only one parameter is configured or both are configured, the query is based on the configured parameters.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsGroupMember")]
        [Validation(Required=false)]
        public bool? IsGroupMember { get; set; }

        /// <summary>
        /// <para>Specifies whether to query multicast sources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: no.</description></item>
        /// <item><description><b>true</b>: yes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is used together with IsGroupMember.</para>
        /// <list type="bullet">
        /// <item><description>If neither parameter is configured, both multicast sources and members are queried by default.</description></item>
        /// <item><description>If only one parameter is configured or both are configured, the query is based on the configured parameters.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsGroupSource")]
        [Validation(Required=false)]
        public bool? IsGroupSource { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The list of elastic network interface (ENI) IDs.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request or if no next query exists.</description></item>
        /// <item><description>If a next query exists, set the value to the NextToken value returned by the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The list of cross-region multicast domain IDs.</para>
        /// </summary>
        [NameInMap("PeerTransitRouterMulticastDomains")]
        [Validation(Required=false)]
        public List<string> PeerTransitRouterMulticastDomains { get; set; }

        /// <summary>
        /// <para>The resource ID associated with the multicast resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-p0w9alkte4w2htrqe****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the multicast resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: queries multicast resources in a virtual private cloud (VPC).</description></item>
        /// <item><description><b>TR</b>: queries cross-region multicast resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The network instance connection ID.</para>
        /// <para>You must specify at least one of TransitRouterMulticastDomainId and TransitRouterAttachmentId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-g3kz2k3u76amsk****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The multicast domain ID.</para>
        /// <para>You must specify at least one of TransitRouterMulticastDomainId and TransitRouterAttachmentId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-mcast-domain-5mjb5gjb6dgu98****</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainId")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainId { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
