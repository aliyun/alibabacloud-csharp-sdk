// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallPolicyBackUpAssociationListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of traffic redirection instances.</para>
        /// </summary>
        [NameInMap("CandidateList")]
        [Validation(Required=false)]
        public string CandidateListShrink { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC firewall for a transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-8b268ce1b26e4c68****</para>
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
        /// <para>The ID of the firewall routing policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-5dcafb12ff794a56****</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

    }

}
