// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartConfigRuleEvaluationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the compliance package.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/606968.html">ListCompliancePacks</a>.</para>
        /// <remarks>
        /// <para>Specify either <c>CompliancePackId</c> or <c>ConfigRuleId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cp-ac16626622af0053****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/609222.html">ListConfigRules</a>.</para>
        /// <remarks>
        /// <para>Specify either <c>CompliancePackId</c> or <c>ConfigRuleId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cr-9920626622af0035****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore evaluation results that were ignored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Restores ignored evaluation results.</para>
        /// </description></item>
        /// <item><description><para>false (default): Does not restore ignored evaluation results.</para>
        /// </description></item>
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
