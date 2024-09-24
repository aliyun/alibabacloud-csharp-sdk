// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyTrFirewallV2RoutePolicyScopeRequest : TeaModel {
        /// <summary>
        /// <para>The secondary traffic redirection instances.</para>
        /// </summary>
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public List<ModifyTrFirewallV2RoutePolicyScopeRequestDestCandidateList> DestCandidateList { get; set; }
        public class ModifyTrFirewallV2RoutePolicyScopeRequestDestCandidateList : TeaModel {
            /// <summary>
            /// <para>The ID of the traffic redirection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze9epancaw8t4shajuzi</para>
            /// </summary>
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            /// <summary>
            /// <para>The type of the traffic redirection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-6520de0253bc4669bbd9</para>
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
        /// <para>The primary traffic redirection instances.</para>
        /// </summary>
        [NameInMap("SrcCandidateList")]
        [Validation(Required=false)]
        public List<ModifyTrFirewallV2RoutePolicyScopeRequestSrcCandidateList> SrcCandidateList { get; set; }
        public class ModifyTrFirewallV2RoutePolicyScopeRequestSrcCandidateList : TeaModel {
            /// <summary>
            /// <para>The ID of the traffic redirection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze9epancaw8t4shajuzi</para>
            /// </summary>
            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            /// <summary>
            /// <para>The type of the traffic redirection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("CandidateType")]
            [Validation(Required=false)]
            public string CandidateType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the routing policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-4d724d0139df48f18091</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

    }

}
