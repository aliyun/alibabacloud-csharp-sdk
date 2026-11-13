// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyFirewallV2RoutePolicySwitchRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewalls.</para>
        /// <para><b>Note</b>: This parameter is actually required. If it is not provided, the operation returns ErrorParameters (-360103).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-5b202e7f0be64611****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
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
        /// <para>The ID of the firewall route policy.</para>
        /// <para><b>Note</b>: This parameter is actually required. If it is not provided or the policy does not exist, the operation returns ErrorTrFirewallPolicyNotFound (-361043). You can call DescribeTrFirewallV2RoutePolicyList to query valid route policy IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-93684cc5caa44b2e****</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

        /// <summary>
        /// <para>The status of the policy switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>open: Enabled.</para>
        /// </description></item>
        /// <item><description><para>close: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para><b>Note</b>: This parameter is actually required. If it is not provided or the value is not within the preceding range, the operation returns ErrorParameters (-360103).</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicySwitchStatus")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicySwitchStatus { get; set; }

    }

}
