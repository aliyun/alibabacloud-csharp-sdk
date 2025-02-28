// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyTransitRouterMulticastDomainRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-4266****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Multicast domain feature.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public ModifyTransitRouterMulticastDomainRequestOptions Options { get; set; }
        public class ModifyTransitRouterMulticastDomainRequestOptions : TeaModel {
            /// <summary>
            /// <para>Indicates whether the IGMP feature is enabled for the multicast domain. Once enabled, hosts can dynamically join or leave multicast groups by using the IGMP protocol. Default value: <b>enable</b>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The IGMP feature is in beta testing. To use it, contact your account manager.</description></item>
            /// <item><description>The IGMP feature cannot be disabled after it is enabled.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("Igmpv2Support")]
            [Validation(Required=false)]
            public string Igmpv2Support { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The new description of the multicast domain.</para>
        /// <para>This parameter is optional. If you enter a description, it must be 1 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainDescription")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainDescription { get; set; }

        /// <summary>
        /// <para>The ID of the multicast domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-mcast-domain-40cwj0rgzgdtam****</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainId")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainId { get; set; }

        /// <summary>
        /// <para>The new name of the multicast domain.</para>
        /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainName")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainName { get; set; }

    }

}
