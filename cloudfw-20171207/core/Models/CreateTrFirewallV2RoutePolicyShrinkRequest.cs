// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateTrFirewallV2RoutePolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of destination network instances.</para>
        /// </summary>
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public string DestCandidateListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the VPC firewall instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-f8ce36689b224f77****</para>
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
        /// <para>The description of the routing policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Singapore Point to Multipoint</para>
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// <para>The name of the routing policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Singapore Point to Multipoint</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The traffic redirection scenario of the Enterprise Edition transit router. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>fullmesh</b>: full-mesh</para>
        /// </description></item>
        /// <item><description><para><b>one_to_one</b>: point-to-point</para>
        /// </description></item>
        /// <item><description><para><b>end_to_end</b>: point-to-multipoint</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fullmesh</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The list of source network instances.</para>
        /// </summary>
        [NameInMap("SrcCandidateList")]
        [Validation(Required=false)]
        public string SrcCandidateListShrink { get; set; }

    }

}
