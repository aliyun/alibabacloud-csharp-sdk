// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRuleComplianceByPackResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance results for the rules in the compliance package.</para>
        /// </summary>
        [NameInMap("ConfigRuleComplianceResult")]
        [Validation(Required=false)]
        public GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult ConfigRuleComplianceResult { get; set; }
        public class GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResult : TeaModel {
            /// <summary>
            /// <para>The ID of the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-541e626622af0087****</para>
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// <para>The number of compliant rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CompliantCount")]
            [Validation(Required=false)]
            public int? CompliantCount { get; set; }

            /// <summary>
            /// <para>The list of rules in the compliance package and their compliance results.</para>
            /// </summary>
            [NameInMap("ConfigRuleCompliances")]
            [Validation(Required=false)]
            public List<GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances> ConfigRuleCompliances { get; set; }
            public class GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances : TeaModel {
                /// <summary>
                /// <para>The compliance evaluation result of the rule. Valid values:</para>
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
                /// <para>The ID of the rule in the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cr-fdc8626622af00f9****</para>
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// <para>The name of the rule in the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The bandwidth of the Elastic IP instance meets the minimum requirements.</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

            }

            /// <summary>
            /// <para>The number of ignored rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IgnoredCount")]
            [Validation(Required=false)]
            public int? IgnoredCount { get; set; }

            /// <summary>
            /// <para>The total number of rules within the compliance package whose evaluation results are &quot;No Data&quot; when assessing resources.</para>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            /// <summary>
            /// <para>The number of rules that are not applicable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotApplicableCount")]
            [Validation(Required=false)]
            public int? NotApplicableCount { get; set; }

            /// <summary>
            /// <para>The total number of rules in the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
