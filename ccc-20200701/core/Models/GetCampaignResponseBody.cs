// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetCampaignResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCampaignResponseBodyData Data { get; set; }
        public class GetCampaignResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1634008800000</para>
            /// </summary>
            [NameInMap("ActualEndTime")]
            [Validation(Required=false)]
            public long? ActualEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1634000460000</para>
            /// </summary>
            [NameInMap("ActualStartTime")]
            [Validation(Required=false)]
            public long? ActualStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6badb397-a8b5-40b6-21019d382a09</para>
            /// </summary>
            [NameInMap("CampaignId")]
            [Validation(Required=false)]
            public string CampaignId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CasesAborted")]
            [Validation(Required=false)]
            public long? CasesAborted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("CasesConnected")]
            [Validation(Required=false)]
            public long? CasesConnected { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CasesUncompleted")]
            [Validation(Required=false)]
            public long? CasesUncompleted { get; set; }

            [NameInMap("CasesUncompletedAfterAttempt")]
            [Validation(Required=false)]
            public string CasesUncompletedAfterAttempt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CasesUncompletedAfterAttempted")]
            [Validation(Required=false)]
            public long? CasesUncompletedAfterAttempted { get; set; }

            [NameInMap("CompletionRate")]
            [Validation(Required=false)]
            public float? CompletionRate { get; set; }

            [NameInMap("ContactFlowId")]
            [Validation(Required=false)]
            public string ContactFlowId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxAttemptCount")]
            [Validation(Required=false)]
            public long? MaxAttemptCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinAttemptInterval")]
            [Validation(Required=false)]
            public long? MinAttemptInterval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-campaign</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1634054400000</para>
            /// </summary>
            [NameInMap("PlanedEndTime")]
            [Validation(Required=false)]
            public long? PlanedEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1633968000000</para>
            /// </summary>
            [NameInMap("PlanedStartTime")]
            [Validation(Required=false)]
            public long? PlanedStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>skillgroup@ccc-test</para>
            /// </summary>
            [NameInMap("QueueId")]
            [Validation(Required=false)]
            public string QueueId { get; set; }

            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Simulation")]
            [Validation(Required=false)]
            public bool? Simulation { get; set; }

            [NameInMap("SimulationParameters")]
            [Validation(Required=false)]
            public string SimulationParameters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Completed</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;ratio&quot;:1}</para>
            /// </summary>
            [NameInMap("StrategyParameters")]
            [Validation(Required=false)]
            public string StrategyParameters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PACING</para>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCases")]
            [Validation(Required=false)]
            public long? TotalCases { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6CCEF32F-8614-535F-A1D9-D85B8C0DC4F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
