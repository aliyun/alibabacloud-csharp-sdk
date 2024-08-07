// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCustomizeRuleCountResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCustomizeRuleCountResponseBodyData Data { get; set; }
        public class DescribeCustomizeRuleCountResponseBodyData : TeaModel {
            /// <summary>
            /// 同类聚合规则数。
            /// </summary>
            [NameInMap("AggregationRuleNum")]
            [Validation(Required=false)]
            public int? AggregationRuleNum { get; set; }

            /// <summary>
            /// 自定义规则数。
            /// </summary>
            [NameInMap("CustomizeRuleNum")]
            [Validation(Required=false)]
            public int? CustomizeRuleNum { get; set; }

            /// <summary>
            /// 专家规则数。
            /// </summary>
            [NameInMap("ExpertRuleNum")]
            [Validation(Required=false)]
            public int? ExpertRuleNum { get; set; }

            /// <summary>
            /// 图计算规则数。
            /// </summary>
            [NameInMap("GraphComputingRuleNum")]
            [Validation(Required=false)]
            public int? GraphComputingRuleNum { get; set; }

            /// <summary>
            /// The number of rules that are used to identify high-risk threats.
            /// </summary>
            [NameInMap("HighRuleNum")]
            [Validation(Required=false)]
            public int? HighRuleNum { get; set; }

            /// <summary>
            /// The total number of rules.
            /// </summary>
            [NameInMap("InUseRuleNum")]
            [Validation(Required=false)]
            public int? InUseRuleNum { get; set; }

            /// <summary>
            /// The number of rules that are used to identify low-risk threats.
            /// </summary>
            [NameInMap("LowRuleNum")]
            [Validation(Required=false)]
            public int? LowRuleNum { get; set; }

            /// <summary>
            /// The number of rules that are used to identify medium-risk threats.
            /// </summary>
            [NameInMap("MediumRuleNum")]
            [Validation(Required=false)]
            public int? MediumRuleNum { get; set; }

            /// <summary>
            /// 预定义规则数。
            /// </summary>
            [NameInMap("PredefinedRuleNum")]
            [Validation(Required=false)]
            public int? PredefinedRuleNum { get; set; }

            /// <summary>
            /// 告警透传规则数。
            /// </summary>
            [NameInMap("SingleAlertRuleNum")]
            [Validation(Required=false)]
            public int? SingleAlertRuleNum { get; set; }

            /// <summary>
            /// 总规则数。
            /// </summary>
            [NameInMap("TotalRuleNum")]
            [Validation(Required=false)]
            public int? TotalRuleNum { get; set; }

            /// <summary>
            /// 不产生事件规则数。
            /// </summary>
            [NameInMap("UnEventRuleNum")]
            [Validation(Required=false)]
            public int? UnEventRuleNum { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
