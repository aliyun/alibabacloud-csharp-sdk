// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRuleSummaryByRiskLevelResponseBody : TeaModel {
        /// <summary>
        /// <para>The summary of compliance evaluation results by rule risk level.</para>
        /// </summary>
        [NameInMap("ConfigRuleSummaries")]
        [Validation(Required=false)]
        public List<GetAggregateConfigRuleSummaryByRiskLevelResponseBodyConfigRuleSummaries> ConfigRuleSummaries { get; set; }
        public class GetAggregateConfigRuleSummaryByRiskLevelResponseBodyConfigRuleSummaries : TeaModel {
            /// <summary>
            /// <para>The number of rules against which specific resources are evaluated as compliant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CompliantCount")]
            [Validation(Required=false)]
            public int? CompliantCount { get; set; }

            /// <summary>
            /// <para>The number of rules against which specific resources are evaluated as non-compliant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            /// <summary>
            /// <para>The risk level of the resources that do not comply with the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: high</description></item>
            /// <item><description>2: medium</description></item>
            /// <item><description>3: low</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3CDD98C-DE65-46AC-B2D2-04A4A9AB5B73</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
