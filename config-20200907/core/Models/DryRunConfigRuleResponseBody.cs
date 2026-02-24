// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DryRunConfigRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance type of the rule. Valid values:</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C32EEAD7-BF64-5927-977A-AFF9342B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The context of the rule conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;result&quot;:&quot;NON_COMPLIANT&quot;,
        ///   &quot;children&quot;:[
        ///     {
        ///       &quot;featureValue&quot;:&quot;1&quot;,
        ///       &quot;featureSource&quot;:&quot;CONFIGURATION&quot;,
        ///       &quot;result&quot;:&quot;NON_COMPLIANT&quot;,
        ///       &quot;desired&quot;:&quot;4&quot;,
        ///       &quot;children&quot;:[],
        ///       &quot;operator&quot;:&quot;StringEquals&quot;,
        ///       &quot;featurePath&quot;:&quot;$.Cpu&quot;
        ///     }
        ///   ],
        ///   &quot;operator&quot;:&quot;and&quot;
        /// }</para>
        /// </summary>
        [NameInMap("RuleConditionContext")]
        [Validation(Required=false)]
        public string RuleConditionContext { get; set; }

    }

}
