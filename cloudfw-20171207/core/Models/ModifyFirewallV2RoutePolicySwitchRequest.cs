// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyFirewallV2RoutePolicySwitchRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the VPC boundary firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-5b202e7f0be64611****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore the traffic redirection configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Rolls back the route.</para>
        /// </description></item>
        /// <item><description><para>false: Revokes the route.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShouldRecover")]
        [Validation(Required=false)]
        public string ShouldRecover { get; set; }

        /// <summary>
        /// <para>The ID of the routing policy for the firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-93684cc5caa44b2e****</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

        /// <summary>
        /// <para>The status of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>open: Enables the policy.</para>
        /// </description></item>
        /// <item><description><para>close: Disables the policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicySwitchStatus")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicySwitchStatus { get; set; }

    }

}
