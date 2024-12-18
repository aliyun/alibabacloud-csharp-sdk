// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartAggregateConfigRuleEvaluationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-3a58626622af0005****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>The ID of the compliance package.</para>
        /// <para>For more information about how to obtain the ID of a compliance package, see <a href="https://help.aliyun.com/document_detail/262059.html">ListAggregateCompliancePacks</a>.</para>
        /// <remarks>
        /// <para>You must configure either the <c>CompliancePackId</c> or <c>ConfigRuleId</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cp-ac16626622af0053****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>For more information about how to query the ID of a rule, see <a href="https://help.aliyun.com/document_detail/264148.html">ListAggregateConfigRules</a>.</para>
        /// <remarks>
        /// <para> You must configure either the <c>CompliancePackId</c> or <c>ConfigRuleId</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cr-c169626622af009f****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <para>Specifies whether to re-evaluate the ignored non-compliant resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: re-evaluates the ignored non-compliant resource based on the rule.</description></item>
        /// <item><description>false (default): does not re-evaluate the ignored non-compliant resource based on the rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RevertEvaluation")]
        [Validation(Required=false)]
        public bool? RevertEvaluation { get; set; }

    }

}
