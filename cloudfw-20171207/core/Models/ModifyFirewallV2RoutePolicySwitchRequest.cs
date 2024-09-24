// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyFirewallV2RoutePolicySwitchRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-5b202e7f0be64611****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
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
        /// <para>Specifies whether to restore the traffic redirection configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: roll back</description></item>
        /// <item><description>false: withdraw</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShouldRecover")]
        [Validation(Required=false)]
        public string ShouldRecover { get; set; }

        /// <summary>
        /// <para>The ID of the routing policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-93684cc5caa44b2e****</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

        /// <summary>
        /// <para>The status of the routing policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>open: enabled</description></item>
        /// <item><description>close: disabled</description></item>
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
