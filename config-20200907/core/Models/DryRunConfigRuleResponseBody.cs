// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DryRunConfigRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>COMPLIANT</para>
        /// </summary>
        [NameInMap("ComplianceType")]
        [Validation(Required=false)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C32EEAD7-BF64-5927-977A-AFF9342B7275</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///             &quot;result&quot;:&quot;NON_COMPLIANT&quot;,
        ///             &quot;children&quot;:[
        ///                 {
        ///                     &quot;featureValue&quot;:&quot;1&quot;,
        ///                     &quot;featureSource&quot;:&quot;CONFIGURATION&quot;,
        ///                     &quot;result&quot;:&quot;NON_COMPLIANT&quot;,
        ///                     &quot;desired&quot;:&quot;4&quot;,
        ///                     &quot;children&quot;:[],
        ///                     &quot;operator&quot;:&quot;StringEquals&quot;,
        ///                     &quot;featurePath&quot;:&quot;$.Cpu&quot;
        ///                 }
        ///             ],
        ///             &quot;operator&quot;:&quot;and&quot;
        ///         }
        ///     }</para>
        /// </summary>
        [NameInMap("RuleConditionContext")]
        [Validation(Required=false)]
        public string RuleConditionContext { get; set; }

    }

}
