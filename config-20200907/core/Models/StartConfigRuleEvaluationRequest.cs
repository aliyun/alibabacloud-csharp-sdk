// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartConfigRuleEvaluationRequest : TeaModel {
        /// <summary>
        /// <para>The compliance package ID.</para>
        /// <para>For more information about how to obtain the ID of a compliance package, see <a href="https://help.aliyun.com/document_detail/606968.html">ListCompliancePacks</a>.</para>
        /// <remarks>
        /// <para> You must configure either the <c>CompliancePackId</c> or <c>ConfigRuleId</c> parameter.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/609222.html">ListConfigRules</a> operation to obtain the rule ID.</para>
        /// <remarks>
        /// <para> You must configure either the <c>CompliancePackId</c> or <c>ConfigRuleId</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cr-9920626622af0035****</para>
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
