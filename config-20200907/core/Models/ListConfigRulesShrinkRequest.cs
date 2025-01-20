// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The compliance package ID.</para>
        /// <para>For more information about how to obtain the ID of a compliance package, see <a href="https://help.aliyun.com/document_detail/606968.html">ListCompliancePacks</a>.</para>
        /// <remarks>
        /// <para> You must configure either the <c>CompliancePackId</c> or <c>ConfigRuleId</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cp-fe416457e0d90022****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// <para>The compliance evaluation result of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>COMPLIANT: The resources are evaluated as compliant.</description></item>
        /// <item><description>NON_COMPLIANT: The resources are evaluated as non-compliant.</description></item>
        /// <item><description>NOT_APPLICABLE: The rule does not apply to the resources.</description></item>
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
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-rule-name</para>
        /// </summary>
        [NameInMap("ConfigRuleName")]
        [Validation(Required=false)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACTIVE: The rule is enabled.</description></item>
        /// <item><description>DELETING: The rule is being deleted.</description></item>
        /// <item><description>EVALUATING: The rule is being used to evaluate resource configurations.</description></item>
        /// <item><description>INACTIVE: The rule is disabled.</description></item>
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
        /// <para>You can perform a fuzzy search by rule ID, rule name, rule description, or managed rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Page numbers start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100. A minimum of 1 entry can be returned per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the resources to be evaluated based on the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// <para>The risk level of the resources that are not compliant with the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: high</description></item>
        /// <item><description>2: medium</description></item>
        /// <item><description>3: low</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// <para>You can add up to 20 tags to a resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
