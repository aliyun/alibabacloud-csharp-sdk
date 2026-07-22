// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallV2RoutePolicyListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95EB5F3A-67FE-5780-92BD-5ECBA772AB7E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The list of firewall routing policies.</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicies")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePolicies> TrFirewallRoutePolicies { get; set; }
        public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePolicies : TeaModel {
            /// <summary>
            /// <para>The list of secondary traffic redirection instances.</para>
            /// </summary>
            [NameInMap("DestCandidateList")]
            [Validation(Required=false)]
            public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesDestCandidateList> DestCandidateList { get; set; }
            public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesDestCandidateList : TeaModel {
                /// <summary>
                /// <para>The ID of the traffic redirection instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze9epancaw8t4sha****</para>
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
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Point to multipoint</para>
            /// </summary>
            [NameInMap("PolicyDescription")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Singapore Point to Multipoint</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The policy status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>creating: being created</para>
            /// </description></item>
            /// <item><description><para>deleting: being deleted</para>
            /// </description></item>
            /// <item><description><para>opening: being enabled</para>
            /// </description></item>
            /// <item><description><para>opened: enabled</para>
            /// </description></item>
            /// <item><description><para>closing: being disabled</para>
            /// </description></item>
            /// <item><description><para>closed: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>opened</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// <para>The traffic redirection scenario type for the virtual private cloud (VPC) firewall on CEN Enterprise Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>fullmesh</b>: multi-point interconnection</para>
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
            /// <para>The list of primary traffic redirection instances.</para>
            /// </summary>
            [NameInMap("SrcCandidateList")]
            [Validation(Required=false)]
            public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesSrcCandidateList> SrcCandidateList { get; set; }
            public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesSrcCandidateList : TeaModel {
                /// <summary>
                /// <para>The ID of the traffic redirection instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze9epancaw8t4sha****</para>
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
            /// <para>The ID of the firewall routing policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy-7b66257c14e141fb****</para>
            /// </summary>
            [NameInMap("TrFirewallRoutePolicyId")]
            [Validation(Required=false)]
            public string TrFirewallRoutePolicyId { get; set; }

        }

    }

}
