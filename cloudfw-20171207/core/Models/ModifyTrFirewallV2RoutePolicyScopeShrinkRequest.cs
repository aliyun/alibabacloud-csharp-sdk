// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyTrFirewallV2RoutePolicyScopeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of secondary traffic redirection instances.</para>
        /// </summary>
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public string DestCandidateListShrink { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewalls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-6520de0253bc4669****</para>
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
        /// <item><description><para>true: Route rollback.</para>
        /// </description></item>
        /// <item><description><para>false: Route withdrawal.</para>
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
        /// <para>The list of primary traffic redirection instances.</para>
        /// </summary>
        [NameInMap("SrcCandidateList")]
        [Validation(Required=false)]
        public string SrcCandidateListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the firewall route policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-4d724d0139df48f1****</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

    }

}
