// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatRateLimitRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The NAT gateway instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1b0lic8uz4r6vf2****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is to be sent.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2315DEB7-5E92-423A-91F7-4C1EC9AD97C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of rate limiting rules.</para>
        /// </summary>
        [NameInMap("RuleInfos")]
        [Validation(Required=false)]
        public List<ListNatRateLimitRulesResponseBodyRuleInfos> RuleInfos { get; set; }
        public class ListNatRateLimitRulesResponseBodyRuleInfos : TeaModel {
            /// <summary>
            /// <para>The bandwidth limit. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BandwidthLimit")]
            [Validation(Required=false)]
            public string BandwidthLimit { get; set; }

            /// <summary>
            /// <para>The source match type of the rate limiting rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CIDR</b>: CIDR block match. This is the default value.</description></item>
            /// <item><description><b>TUNNEL</b>: tunnel match. If this value is specified, a corresponding SNAT rule of the TUNNEL type must exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CIDR</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The description of the rate limiting rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RuleDescription")]
            [Validation(Required=false)]
            public string RuleDescription { get; set; }

            /// <summary>
            /// <para>The ID of the rate limiting rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>limit-rule-****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the rate limiting rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-rule</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The source CIDR blocks of the rate limiting rule.</para>
            /// </summary>
            [NameInMap("SourceCIDRs")]
            [Validation(Required=false)]
            public List<string> SourceCIDRs { get; set; }

            /// <summary>
            /// <para>The status of the rate limiting rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b>: The rule is available.</description></item>
            /// <item><description><b>Deleting</b>: The rule is being deleted.</description></item>
            /// <item><description><b>Modifying</b>: The rule is being modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tunnel index. If the MatchType parameter is set to TUNNEL, a corresponding SNAT rule must exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TunnelIndex")]
            [Validation(Required=false)]
            public string TunnelIndex { get; set; }

        }

        /// <summary>
        /// <para>The total number of rate limiting rules returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
