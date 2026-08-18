// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetSecuritySuggestionListRequest : TeaModel {
        /// <summary>
        /// <para>The request parameters.</para>
        /// </summary>
        [NameInMap("ListConfigRulesRequest")]
        [Validation(Required=false)]
        public GetSecuritySuggestionListRequestListConfigRulesRequest ListConfigRulesRequest { get; set; }
        public class GetSecuritySuggestionListRequestListConfigRulesRequest : TeaModel {
            /// <summary>
            /// <para>The compliance package ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-d7b061dbe91500aa179a</para>
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// <para>The compliance evaluation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>COMPLIANT</b>: Compliant.</description></item>
            /// <item><description><b>NON_COMPLIANT</b>: Non-compliant.</description></item>
            /// <item><description><b>NOT_APPLICABLE</b>: Not applicable.</description></item>
            /// <item><description><b>INSUFFICIENT_DATA</b>: Insufficient data.</description></item>
            /// <item><description><b>IGNORED</b>: Ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLIANT</para>
            /// </summary>
            [NameInMap("ComplianceType")]
            [Validation(Required=false)]
            public string ComplianceType { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The name of the rule.</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The rule running status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ACTIVE</b>: Active.</description></item>
            /// <item><description><b>DELETING</b>: Being deleted.</description></item>
            /// <item><description><b>EVALUATING</b>: Being evaluated.</description></item>
            /// <item><description><b>INACTIVE</b>: Inactive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("ConfigRuleState")]
            [Validation(Required=false)]
            public string ConfigRuleState { get; set; }

            /// <summary>
            /// <para>The query keyword.</para>
            /// <para>Supports fuzzy match on the rule ID, rule name, rule description, and rule template identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// <remarks>
            /// <para>Minimum value: 1. Default value: 1.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// <remarks>
            /// <para>Valid values: 1 to 100. Minimum value: 1. Default value: 10.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The resource type evaluated by the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::Instance</para>
            /// </summary>
            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public string ResourceTypes { get; set; }

            /// <summary>
            /// <para>The risk level of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: High risk.</description></item>
            /// <item><description><b>2</b>: Medium risk.</description></item>
            /// <item><description><b>3</b>: Low risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

    }

}
