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
        /// <para>The routing policies.</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicies")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePolicies> TrFirewallRoutePolicies { get; set; }
        public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePolicies : TeaModel {
            /// <summary>
            /// <para>The secondary traffic redirection instances.</para>
            /// </summary>
            [NameInMap("DestCandidateList")]
            [Validation(Required=false)]
            public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesDestCandidateList> DestCandidateList { get; set; }
            public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesDestCandidateList : TeaModel {
                /// <summary>
                /// <para>The ID of the secondary traffic redirection instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze9epancaw8t4sha****</para>
                /// </summary>
                [NameInMap("CandidateId")]
                [Validation(Required=false)]
                public string CandidateId { get; set; }

                /// <summary>
                /// <para>The type of the secondary traffic redirection instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("CandidateType")]
                [Validation(Required=false)]
                public string CandidateType { get; set; }

            }

            /// <summary>
            /// <para>The description of the routing policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyDescription")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// <para>The name of the routing policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEST_VPC_FW</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The status of the routing policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>creating: The policy is being created.</description></item>
            /// <item><description>deleting: The policy is being deleted.</description></item>
            /// <item><description>opening: The policy is being enabled.</description></item>
            /// <item><description>opened: The policy is enabled.</description></item>
            /// <item><description>closing: The policy is being disabled.</description></item>
            /// <item><description>closed: The policy is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>opened</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// <para>The type of the traffic redirection scenario of the VPC firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>fullmesh</b>: interconnected instances</description></item>
            /// <item><description><b>one_to_one</b>: instance to instance</description></item>
            /// <item><description><b>end_to_end</b>: instance to instances</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fullmesh</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The primary traffic redirection instances.</para>
            /// </summary>
            [NameInMap("SrcCandidateList")]
            [Validation(Required=false)]
            public List<DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesSrcCandidateList> SrcCandidateList { get; set; }
            public class DescribeTrFirewallV2RoutePolicyListResponseBodyTrFirewallRoutePoliciesSrcCandidateList : TeaModel {
                /// <summary>
                /// <para>The ID of the primary traffic redirection instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze9epancaw8t4sha****</para>
                /// </summary>
                [NameInMap("CandidateId")]
                [Validation(Required=false)]
                public string CandidateId { get; set; }

                /// <summary>
                /// <para>The type of the primary traffic redirection instance.</para>
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
