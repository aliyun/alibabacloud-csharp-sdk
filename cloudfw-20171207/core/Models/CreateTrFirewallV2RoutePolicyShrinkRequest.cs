// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateTrFirewallV2RoutePolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of secondary traffic redirection instances.</para>
        /// <remarks>
        /// <para>DestCandidateList is required. If this parameter is not specified, an ErrorParameters(400) error is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public string DestCandidateListShrink { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewalls at the border.</para>
        /// <remarks>
        /// <para>FirewallId is required. If this parameter is not specified, an ErrorParameters(400) error is returned. You can call the DescribeTrFirewallsV2List operation to obtain instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-f8ce36689b224f77****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The language in which you want to receive messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The description of the traffic redirection policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Singapore Point to Multipoint</para>
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// <para>The name of the traffic redirection policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Singapore Point to Multipoint</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The type of the traffic redirection scenario for virtual private cloud (VPC) firewalls at the border in the Enterprise Edition Cloud Enterprise Network (CEN). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>fullmesh</b>: Multi-point interconnection.</para>
        /// </description></item>
        /// <item><description><para><b>one_to_one</b>: Point-to-point.</para>
        /// </description></item>
        /// <item><description><para><b>end_to_end</b>: Point-to-multipoint.</para>
        /// <remarks>
        /// <para>PolicyType is required. If this parameter is not specified, an ErrorParameters(400) error is returned.</para>
        /// </remarks>
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
        /// <para>The list of primary traffic redirection instances.</para>
        /// <remarks>
        /// <para>SrcCandidateList is required. If this parameter is not specified, an ErrorParameters(400) error is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SrcCandidateList")]
        [Validation(Required=false)]
        public string SrcCandidateListShrink { get; set; }

    }

}
