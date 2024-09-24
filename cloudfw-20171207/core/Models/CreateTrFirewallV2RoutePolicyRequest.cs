// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateTrFirewallV2RoutePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The secondary traffic redirection instances.</para>
        /// </summary>
        [NameInMap("DestCandidateList")]
        [Validation(Required=false)]
        public List<CreateTrFirewallV2RoutePolicyRequestDestCandidateList> DestCandidateList { get; set; }
        public class CreateTrFirewallV2RoutePolicyRequestDestCandidateList : TeaModel {
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
        /// <para>The instance ID of the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-f8ce36689b224f77****</para>
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
        /// <para>The description of the traffic redirection instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// <para>The name of the traffic redirection instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST_VPC_FW</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

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
        public List<CreateTrFirewallV2RoutePolicyRequestSrcCandidateList> SrcCandidateList { get; set; }
        public class CreateTrFirewallV2RoutePolicyRequestSrcCandidateList : TeaModel {
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

    }

}
