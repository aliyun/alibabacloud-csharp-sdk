// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class RegisterTransitRouterMulticastGroupMembersRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The IP address of the multicast group to which the multicast members belong. Valid values: <b>224.0.0.1</b> to <b>239.255.255.254</b>.</para>
        /// <para>If the multicast group does not exist in the specified multicast domain, the system automatically creates the multicast group in the multicast domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239.XX.XX.2</para>
        /// </summary>
        [NameInMap("GroupIpAddress")]
        [Validation(Required=false)]
        public string GroupIpAddress { get; set; }

        /// <summary>
        /// <para>The IDs of the ENIs.</para>
        /// </summary>
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of inter-region multicast domains.</para>
        /// </summary>
        [NameInMap("PeerTransitRouterMulticastDomains")]
        [Validation(Required=false)]
        public List<string> PeerTransitRouterMulticastDomains { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the multicast domain to which the multicast members belong.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-mcast-domain-91wpg6wbhchjeq****</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainId")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the ENI belongs.</para>
        /// <list type="bullet">
        /// <item><description>If the ENI belongs to the current Alibaba Cloud account, ignore this parameter.</description></item>
        /// <item><description>If the ENI belongs to a different Alibaba Cloud account, you must set this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wz9fusm6zq8uy7cfa****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
