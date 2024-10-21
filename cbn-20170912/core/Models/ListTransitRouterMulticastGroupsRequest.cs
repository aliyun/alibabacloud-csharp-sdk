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
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among all requests. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IP address of the multicast group.</para>
        /// <para>Each multicast group is identified by its IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239.XX.XX.2</para>
        /// </summary>
        [NameInMap("GroupIpAddress")]
        [Validation(Required=false)]
        public string GroupIpAddress { get; set; }

        /// <summary>
        /// <para>Specified whether to query the multicast members. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter must be specified together with the IsGroupMember parameter.</description></item>
        /// <item><description>If you do not set IsGroupMember or IsGroupSource, both the multicast sources and members are queried.</description></item>
        /// <item><description>If you set only one of them or both of them, the specified values prevail.</description></item>
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
        /// <para>Specifies whether to query the multicast sources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter must be specified together with the IsGroupMember parameter.</description></item>
        /// </list>
        /// <list type="bullet">
        /// <item><description>If you do not specify IsGroupMember or IsGroupSource, both the multicast sources and members are queried.</description></item>
        /// <item><description>If you specify only one of them or both of them, the specified values prevail.</description></item>
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
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The IDs of ENIs.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query and no next queries are to be sent, ignore this parameter.</description></item>
        /// <item><description>If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.</description></item>
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
        /// <para>The ID of the inter-region multicast domain.</para>
        /// </summary>
        [NameInMap("PeerTransitRouterMulticastDomains")]
        [Validation(Required=false)]
        public List<string> PeerTransitRouterMulticastDomains { get; set; }

        /// <summary>
        /// <para>The ID of the resource associated with the multicast resource.</para>
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
        /// <item><description><b>VPC</b>: queries multicast resources by VPC.</description></item>
        /// <item><description><b>TR</b>: queries multicast resources that are also deployed in a different region.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the network instance connection</para>
        /// <para>You must configure one of the TransitRouterMulticastDomainId and TransitRouterAttachmentId parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-g3kz2k3u76amsk****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The ID of the multicast domain.</para>
        /// <para>You must configure one of the TransitRouterMulticastDomainId and TransitRouterAttachmentId parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-mcast-domain-5mjb5gjb6dgu98****</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainId")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainId { get; set; }

        /// <summary>
        /// <para>The vSwitch IDs.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
