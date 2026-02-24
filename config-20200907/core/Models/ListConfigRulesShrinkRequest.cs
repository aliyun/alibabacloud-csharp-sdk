// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the compliance package.</para>
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
        /// <item><description><para>COMPLIANT: Compliant.</para>
        /// </description></item>
        /// <item><description><para>NON_COMPLIANT: Non-compliant.</para>
        /// </description></item>
        /// <item><description><para>NOT_APPLICABLE: Not applicable.</para>
        /// </description></item>
        /// <item><description><para>INSUFFICIENT_DATA: Insufficient data.</para>
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
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The name of the rule.</para>
        /// </summary>
        [NameInMap("ConfigRuleName")]
        [Validation(Required=false)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// <para>The state of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ACTIVE: The rule is enabled.</para>
        /// </description></item>
        /// <item><description><para>DELETING: The rule is being deleted.</para>
        /// </description></item>
        /// <item><description><para>EVALUATING: The rule is being evaluated.</para>
        /// </description></item>
        /// <item><description><para>INACTIVE: The rule is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("ConfigRuleState")]
        [Validation(Required=false)]
        public string ConfigRuleState { get; set; }

        /// <summary>
        /// <para>The keyword for the fuzzy query.</para>
        /// <para>Supports fuzzy queries by rule ID, rule name, rule description, or rule template identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of resource evaluated by the rule.</para>
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
        /// <item><description><para>1: High risk.</para>
        /// </description></item>
        /// <item><description><para>2: Medium risk.</para>
        /// </description></item>
        /// <item><description><para>3: Low risk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        /// <summary>
        /// <para>The sorting method. This parameter is not required. Set the value to <c>CreateDate-Desc</c> to sort the rules by creation time in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateDate-Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// <para>A maximum of 20 tags can be attached.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
