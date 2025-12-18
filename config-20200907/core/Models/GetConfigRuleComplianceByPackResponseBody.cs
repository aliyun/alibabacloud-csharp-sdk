// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRuleComplianceByPackResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the compliance evaluation results returned.</para>
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

            [NameInMap("CompliantCount")]
            [Validation(Required=false)]
            public int? CompliantCount { get; set; }

            /// <summary>
            /// <para>The rule enabled in the compliance package and the compliance evaluation result returned by the rule.</para>
            /// </summary>
            [NameInMap("ConfigRuleCompliances")]
            [Validation(Required=false)]
            public List<GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances> ConfigRuleCompliances { get; set; }
            public class GetConfigRuleComplianceByPackResponseBodyConfigRuleComplianceResultConfigRuleCompliances : TeaModel {
                /// <summary>
                /// <para>The compliance evaluation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLIANT: The relevant resources are evaluated as compliant.</description></item>
                /// <item><description>NON_COMPLIANT: The relevant resources are evaluated as non-compliant.</description></item>
                /// <item><description>NOT_APPLICABLE: The rule does not apply to your resources.</description></item>
                /// <item><description>INSUFFICIENT_DATA: No resource data is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLIANT</para>
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// <para>The ID of the rule enabled in the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cr-fdc8626622af00f9****</para>
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// <para>The name of the rule enabled in the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-rule-name</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

            }

            [NameInMap("IgnoredCount")]
            [Validation(Required=false)]
            public int? IgnoredCount { get; set; }

            [NameInMap("InsufficientDataCount")]
            [Validation(Required=false)]
            public int? InsufficientDataCount { get; set; }

            /// <summary>
            /// <para>The number of rules against which specific resources are evaluated as non-compliant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            [NameInMap("NotApplicableCount")]
            [Validation(Required=false)]
            public int? NotApplicableCount { get; set; }

            /// <summary>
            /// <para>The total number of rules enabled in the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
