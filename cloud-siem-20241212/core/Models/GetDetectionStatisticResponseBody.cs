// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetDetectionStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The detection rule count result.</para>
        /// </summary>
        [NameInMap("DetectionStatistic")]
        [Validation(Required=false)]
        public GetDetectionStatisticResponseBodyDetectionStatistic DetectionStatistic { get; set; }
        public class GetDetectionStatisticResponseBodyDetectionStatistic : TeaModel {
            [NameInMap("AiPoweredAggregationRuleCount")]
            [Validation(Required=false)]
            public int? AiPoweredAggregationRuleCount { get; set; }

            /// <summary>
            /// <para>The number of online rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DetectionRuleOnlineCount")]
            [Validation(Required=false)]
            public int? DetectionRuleOnlineCount { get; set; }

            /// <summary>
            /// <para>The number of rule templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DetectionRuleTemplateCount")]
            [Validation(Required=false)]
            public int? DetectionRuleTemplateCount { get; set; }

            /// <summary>
            /// <para>The number of test rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DetectionRuleTestCount")]
            [Validation(Required=false)]
            public int? DetectionRuleTestCount { get; set; }

            /// <summary>
            /// <para>The number of graph computing rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("GraphComputeRuleCount")]
            [Validation(Required=false)]
            public int? GraphComputeRuleCount { get; set; }

            /// <summary>
            /// <para>The number of alert pass-through rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PassthroughRuleCount")]
            [Validation(Required=false)]
            public int? PassthroughRuleCount { get; set; }

            /// <summary>
            /// <para>The number of similar aggregation rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("WindowRuleCount")]
            [Validation(Required=false)]
            public int? WindowRuleCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FB890AC-90B2-5EEA-845B-F7C86FB2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
