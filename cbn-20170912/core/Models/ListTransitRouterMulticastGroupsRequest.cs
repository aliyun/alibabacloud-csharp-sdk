// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastGroupsRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request.</para>
        /// <para>Generate a unique value from your client for each request. The \<c>ClientToken\\</c> parameter can contain only ASCII characters.</para>
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
        /// <para>Specifies whether to query multicast members.</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter works with \<c>IsGroupSource\\</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify \<c>IsGroupMember\\</c> or \<c>IsGroupSource\\</c>, the system queries both multicast members and sources.</para>
        /// </description></item>
        /// <item><description><para>If you specify one or both parameters, the system queries resources based on the specified parameters.</para>
        /// </description></item>
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
        /// <para>Specifies whether to query multicast sources.</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter works with \<c>IsGroupMember\\</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify \<c>IsGroupSource\\</c> or \<c>IsGroupMember\\</c>, the system queries both multicast sources and members.</para>
        /// </description></item>
        /// <item><description><para>If you specify one or both parameters, the system queries resources based on the specified parameters.</para>
        /// </description></item>
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
        /// <para>A list of Elastic Network Interface (ENI) IDs.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// <list type="bullet">
        /// <item><description><para>If this is your first query or if no next page exists, do not specify this parameter.</para>
        /// </description></item>
        /// <item><description><para>If a next page exists, set this parameter to the \<c>NextToken\\</c> value that is returned from the previous call.</para>
        /// </description></item>
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
        /// <para>A list of IDs of cross-region multicast domains.</para>
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
        /// <para>The type of the multicast resource.</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: queries information about multicast resources in a VPC.</para>
        /// </description></item>
        /// <item><description><para><b>TR</b>: queries information about cross-region multicast resources.</para>
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
        /// <para>The ID of the network instance connection.</para>
        /// <para>You must specify \<c>TransitRouterMulticastDomainId\\</c> or \<c>TransitRouterAttachmentId\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-g3kz2k3u76amsk****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The ID of the multicast domain.</para>
        /// <para>You must specify \<c>TransitRouterMulticastDomainId\\</c> or \<c>TransitRouterAttachmentId\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-mcast-domain-5mjb5gjb6dgu98****</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainId")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainId { get; set; }

        /// <summary>
        /// <para>A list of vSwitch IDs.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
