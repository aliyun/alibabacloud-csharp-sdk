// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetComplianceSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance summary.</para>
        /// </summary>
        [NameInMap("ComplianceSummary")]
        [Validation(Required=false)]
        public GetComplianceSummaryResponseBodyComplianceSummary ComplianceSummary { get; set; }
        public class GetComplianceSummaryResponseBodyComplianceSummary : TeaModel {
            /// <summary>
            /// <para>The compliance summary by rule.</para>
            /// </summary>
            [NameInMap("ComplianceSummaryByConfigRule")]
            [Validation(Required=false)]
            public GetComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule ComplianceSummaryByConfigRule { get; set; }
            public class GetComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule : TeaModel {
                /// <summary>
                /// <para>The timestamp when the compliance summary was generated. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1589853712165</para>
                /// </summary>
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                /// <summary>
                /// <para>The number of compliant rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                /// <summary>
                /// <para>The number of non-compliant rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("NonCompliantCount")]
                [Validation(Required=false)]
                public int? NonCompliantCount { get; set; }

                /// <summary>
                /// <para>The total number of rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The compliance summary by resource.</para>
            /// </summary>
            [NameInMap("ComplianceSummaryByResource")]
            [Validation(Required=false)]
            public GetComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource ComplianceSummaryByResource { get; set; }
            public class GetComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource : TeaModel {
                /// <summary>
                /// <para>The timestamp when the compliance summary was generated. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1589853712165</para>
                /// </summary>
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                /// <summary>
                /// <para>The number of compliant resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                /// <summary>
                /// <para>The number of non-compliant resources detected by high-risk rules.</para>
                /// <remarks>
                /// <para>Note: This value can be greater than the total number of resources in your account. Resources are counted based on each rule. For example, if a resource is evaluated as non-compliant by two rules, the value of this parameter increases by 2.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HighRiskRuleNonCompliantResourceCount")]
                [Validation(Required=false)]
                public int? HighRiskRuleNonCompliantResourceCount { get; set; }

                /// <summary>
                /// <para>The number of non-compliant resources detected by low-risk rules.</para>
                /// <remarks>
                /// <para>Note: This value can be greater than the total number of resources in your account. Resources are counted based on each rule. For example, if a resource is evaluated as non-compliant by two low-risk rules, the value of this parameter increases by 2.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LowRiskRuleNonCompliantResourceCount")]
                [Validation(Required=false)]
                public int? LowRiskRuleNonCompliantResourceCount { get; set; }

                /// <summary>
                /// <para>The number of non-compliant resources detected by medium-risk rules.</para>
                /// <remarks>
                /// <para>Note: This value can be greater than the total number of resources in your account. Resources are counted based on each rule. For example, if a resource is evaluated as non-compliant by two rules, the value of this parameter increases by 2.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("MediumRiskRuleNonCompliantResourceCount")]
                [Validation(Required=false)]
                public int? MediumRiskRuleNonCompliantResourceCount { get; set; }

                /// <summary>
                /// <para>The number of non-compliant resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("NonCompliantCount")]
                [Validation(Required=false)]
                public int? NonCompliantCount { get; set; }

                /// <summary>
                /// <para>The total number of resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
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
        /// <para>CAEE6F34-DEDC-4BAA-AA8C-946D5D008737</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
