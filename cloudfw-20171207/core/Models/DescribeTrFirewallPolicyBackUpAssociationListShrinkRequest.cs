// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallPolicyBackUpAssociationListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The traffic redirection instances.</para>
        /// </summary>
        [NameInMap("CandidateList")]
        [Validation(Required=false)]
        public string CandidateListShrink { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-8b268ce1b26e4c68****</para>
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
        /// <para>The ID of the routing policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-5dcafb12ff794a56****</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

    }

}
