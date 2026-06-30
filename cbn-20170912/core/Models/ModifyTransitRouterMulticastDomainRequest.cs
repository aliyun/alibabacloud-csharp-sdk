// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyTransitRouterMulticastDomainRequest : TeaModel {
        /// <summary>
        /// <para>A client token that ensures the idempotence of the request.</para>
        /// <para>Generate a unique token on your client for each request. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-4266****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Performs a dry run. The system checks the required parameters, request format, and service limits. If the check fails, an error message is returned. If the check passes, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends the request. If the request passes the check, the name and description of the multicast domain are modified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The feature options of the multicast domain.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public ModifyTransitRouterMulticastDomainRequestOptions Options { get; set; }
        public class ModifyTransitRouterMulticastDomainRequestOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the Internet Group Management Protocol (IGMP) feature for the multicast domain. When this feature is enabled, hosts can use IGMP to dynamically join or leave multicast groups. Set the value to <b>enable</b>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>The IGMP feature is in public preview. To use this feature, contact your account manager.</para>
            /// </description></item>
            /// <item><description><para>You cannot disable the IGMP feature after it is enabled.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("Igmpv2Support")]
            [Validation(Required=false)]
            public string Igmpv2Support { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("StrictSourceControl")]
            [Validation(Required=false)]
            public string StrictSourceControl { get; set; }

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
        /// <para>The description can be empty or 1 to 256 characters long. It cannot start with http\:// or https\://.</para>
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
        /// <para>The name can be empty or 1 to 128 characters long. It cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainName")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainName { get; set; }

    }

}
