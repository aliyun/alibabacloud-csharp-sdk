// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceByConfigRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance evaluation results returned.</para>
        /// </summary>
        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public GetResourceComplianceByConfigRuleResponseBodyComplianceResult ComplianceResult { get; set; }
        public class GetResourceComplianceByConfigRuleResponseBodyComplianceResult : TeaModel {
            /// <summary>
            /// <para>The information about the compliance evaluation.</para>
            /// </summary>
            [NameInMap("Compliances")]
            [Validation(Required=false)]
            public List<GetResourceComplianceByConfigRuleResponseBodyComplianceResultCompliances> Compliances { get; set; }
            public class GetResourceComplianceByConfigRuleResponseBodyComplianceResultCompliances : TeaModel {
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
                /// <para>The number of resources that have the compliance evaluation result. For example, if the value of the <c>ComplianceType</c> parameter is <c>COMPLIANT</c>, this parameter value indicates the number of compliant resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

            }

            /// <summary>
            /// <para>The total number of evaluated resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23306AB1-34E0-468F-BD7B-68D8AEAB753d</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
