// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateComplianceSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance statistics.</para>
        /// </summary>
        [NameInMap("ComplianceSummary")]
        [Validation(Required=false)]
        public GetAggregateComplianceSummaryResponseBodyComplianceSummary ComplianceSummary { get; set; }
        public class GetAggregateComplianceSummaryResponseBodyComplianceSummary : TeaModel {
            /// <summary>
            /// <para>The summary of compliance statistics from the rule dimension.</para>
            /// </summary>
            [NameInMap("ComplianceSummaryByConfigRule")]
            [Validation(Required=false)]
            public GetAggregateComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule ComplianceSummaryByConfigRule { get; set; }
            public class GetAggregateComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule : TeaModel {
                /// <summary>
                /// <para>The time when the compliance statistics were collected. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1589853822103</para>
                /// </summary>
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                /// <summary>
                /// <para>The number of compliant rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                /// <summary>
                /// <para>The number of non-compliant rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("NonCompliantCount")]
                [Validation(Required=false)]
                public int? NonCompliantCount { get; set; }

                /// <summary>
                /// <para>The total number of rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The summary of compliance statistics from the resource dimension.</para>
            /// </summary>
            [NameInMap("ComplianceSummaryByResource")]
            [Validation(Required=false)]
            public GetAggregateComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource ComplianceSummaryByResource { get; set; }
            public class GetAggregateComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource : TeaModel {
                /// <summary>
                /// <para>The time when the compliance statistics were collected. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1589853822103</para>
                /// </summary>
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                /// <summary>
                /// <para>The number of compliant resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                [NameInMap("HighRiskRuleNonCompliantResourceCount")]
                [Validation(Required=false)]
                public int? HighRiskRuleNonCompliantResourceCount { get; set; }

                [NameInMap("LowRiskRuleNonCompliantResourceCount")]
                [Validation(Required=false)]
                public int? LowRiskRuleNonCompliantResourceCount { get; set; }

                [NameInMap("MediumRiskRuleNonCompliantResourceCount")]
                [Validation(Required=false)]
                public int? MediumRiskRuleNonCompliantResourceCount { get; set; }

                /// <summary>
                /// <para>The number of non-compliant resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("NonCompliantCount")]
                [Validation(Required=false)]
                public int? NonCompliantCount { get; set; }

                /// <summary>
                /// <para>The total number of resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>929B8360-BD57-54FF-96DB-AD1D9B476769</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
