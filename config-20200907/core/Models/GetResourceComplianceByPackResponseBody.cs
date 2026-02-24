// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceByPackResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The compliance results of the resources in the compliance package.</para>
        /// </summary>
        [NameInMap("ResourceComplianceResult")]
        [Validation(Required=false)]
        public GetResourceComplianceByPackResponseBodyResourceComplianceResult ResourceComplianceResult { get; set; }
        public class GetResourceComplianceByPackResponseBodyResourceComplianceResult : TeaModel {
            /// <summary>
            /// <para>The ID of the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-541e626622af0087****</para>
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// <para>The number of compliant resources.</para>
            /// <remarks>
            /// <para>Note: A resource is counted each time a rule evaluates it as compliant. For example, if a resource is evaluated as compliant by two rules, it is counted twice.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CompliantCount")]
            [Validation(Required=false)]
            public int? CompliantCount { get; set; }

            /// <summary>
            /// <para>The number of resources whose evaluation results are ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IgnoredCount")]
            [Validation(Required=false)]
            public int? IgnoredCount { get; set; }

            /// <summary>
            /// <para>The total number of resources that the rules in the compliance package evaluate as Insufficient Data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InsufficientDataCount")]
            [Validation(Required=false)]
            public int? InsufficientDataCount { get; set; }

            /// <summary>
            /// <para>The number of non-compliant resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            /// <summary>
            /// <para>The number of resources that are not applicable.</para>
            /// <remarks>
            /// <para>Note: A resource is counted each time a rule evaluates it as not applicable. For example, if a resource is evaluated as not applicable by two rules, it is counted twice.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotApplicableCount")]
            [Validation(Required=false)]
            public int? NotApplicableCount { get; set; }

            /// <summary>
            /// <para>The total number of resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
