// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRuleComplianceByPackResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance results of the rules in the compliance pack.</para>
        /// </summary>
        [NameInMap("ConfigRuleComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult ConfigRuleComplianceResult { get; set; }
        public class GetAggregateConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult : TeaModel {
            /// <summary>
            /// <para>The ID of the compliance pack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-541e626622af0087****</para>
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// <para>The total number of rules for which all evaluation results are <b>Compliant</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CompliantCount")]
            [Validation(Required=false)]
            public int? CompliantCount { get; set; }

            /// <summary>
            /// <para>A list of rule compliance results.</para>
            /// </summary>
            [NameInMap("ConfigRuleCompliances")]
            [Validation(Required=false)]
            public List<GetAggregateConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances> ConfigRuleCompliances { get; set; }
            public class GetAggregateConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances : TeaModel {
                /// <summary>
                /// <para>The compliance result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>COMPLIANT: The rule is compliant.</para>
                /// </description></item>
                /// <item><description><para>NON_COMPLIANT: The rule is non-compliant.</para>
                /// </description></item>
                /// <item><description><para>NOT_APPLICABLE: The rule is not applicable.</para>
                /// </description></item>
                /// <item><description><para>INSUFFICIENT_DATA: No data is available.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLIANT</para>
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// <para>The ID of the rule in the compliance pack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cr-fdc8626622af00f9****</para>
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// <para>The name of the rule in the compliance pack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The bandwidth of the Elastic IP instance meets the minimum requirements.</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

            }

            /// <summary>
            /// <para>The total number of rules whose evaluation results include <b>Ignored</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IgnoredCount")]
            [Validation(Required=false)]
            public int? IgnoredCount { get; set; }

            /// <summary>
            /// <para>The total number of rules whose evaluation results include <b>Insufficient Data</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InsufficientDataCount")]
            [Validation(Required=false)]
            public int? InsufficientDataCount { get; set; }

            /// <summary>
            /// <para>The number of non-compliant rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            /// <summary>
            /// <para>The total number of rules whose evaluation results include <b>Not Applicable</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotApplicableCount")]
            [Validation(Required=false)]
            public int? NotApplicableCount { get; set; }

            /// <summary>
            /// <para>The total number of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6B0C0A8-3245-48F1-AEAB-BC1A446E99D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
