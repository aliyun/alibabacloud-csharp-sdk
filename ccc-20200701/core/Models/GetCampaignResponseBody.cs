// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetCampaignResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCampaignResponseBodyData Data { get; set; }
        public class GetCampaignResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual end time of the predictive outbound campaign. This is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634008800000</para>
            /// </summary>
            [NameInMap("ActualEndTime")]
            [Validation(Required=false)]
            public long? ActualEndTime { get; set; }

            /// <summary>
            /// <para>The actual start time of the predictive outbound campaign. This is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634000460000</para>
            /// </summary>
            [NameInMap("ActualStartTime")]
            [Validation(Required=false)]
            public long? ActualStartTime { get; set; }

            /// <summary>
            /// <para>The ID of the predictive outbound campaign.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6badb397-a8b5-40b6-21019d382a09</para>
            /// </summary>
            [NameInMap("CampaignId")]
            [Validation(Required=false)]
            public string CampaignId { get; set; }

            /// <summary>
            /// <para>The number of aborted contacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CasesAborted")]
            [Validation(Required=false)]
            public long? CasesAborted { get; set; }

            /// <summary>
            /// <para>The number of connected contacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("CasesConnected")]
            [Validation(Required=false)]
            public long? CasesConnected { get; set; }

            /// <summary>
            /// <para>The number of uncompleted contacts.</para>
            /// 
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
            /// <para>The number of attempted but unconnected contacts that are still eligible for redial.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CasesUncompletedAfterAttempted")]
            [Validation(Required=false)]
            public long? CasesUncompletedAfterAttempted { get; set; }

            /// <summary>
            /// <para>The ratio of connected contacts to the total number of contacts.</para>
            /// </summary>
            [NameInMap("CompletionRate")]
            [Validation(Required=false)]
            public float? CompletionRate { get; set; }

            /// <summary>
            /// <para>The ID of the associated Contact Flow.</para>
            /// </summary>
            [NameInMap("ContactFlowId")]
            [Validation(Required=false)]
            public string ContactFlowId { get; set; }

            /// <summary>
            /// <para>The maximum number of call attempts for each contact. If an attempt fails, the contact is redialed until this limit is reached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxAttemptCount")]
            [Validation(Required=false)]
            public long? MaxAttemptCount { get; set; }

            /// <summary>
            /// <para>The minimum interval, in seconds, to wait before redialing a failed call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinAttemptInterval")]
            [Validation(Required=false)]
            public long? MinAttemptInterval { get; set; }

            /// <summary>
            /// <para>The name of the predictive outbound campaign.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-campaign</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The planned end time of the predictive outbound campaign. This is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634054400000</para>
            /// </summary>
            [NameInMap("PlanedEndTime")]
            [Validation(Required=false)]
            public long? PlanedEndTime { get; set; }

            /// <summary>
            /// <para>The planned start time of the predictive outbound campaign. This is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1633968000000</para>
            /// </summary>
            [NameInMap("PlanedStartTime")]
            [Validation(Required=false)]
            public long? PlanedStartTime { get; set; }

            /// <summary>
            /// <para>The ID of the associated skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skillgroup@ccc-test</para>
            /// </summary>
            [NameInMap("QueueId")]
            [Validation(Required=false)]
            public string QueueId { get; set; }

            /// <summary>
            /// <para>The name of the associated skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试技能组</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>Indicates whether the campaign is a test simulation. This parameter is not intended for production use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Simulation")]
            [Validation(Required=false)]
            public bool? Simulation { get; set; }

            /// <summary>
            /// <para>The parameters for a test simulation. This parameter is not intended for production use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("SimulationParameters")]
            [Validation(Required=false)]
            public string SimulationParameters { get; set; }

            /// <summary>
            /// <para>The state of the predictive outbound campaign.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Completed</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The strategy parameters for the predictive outbound campaign, in JSON format. For a <c>PID</c> strategy, the format is <c>{&quot;abandonRate&quot;:&quot;5&quot;,&quot;historicalConnectedRate&quot;:&quot;35&quot;}</c>. For a <c>PACING</c> strategy, the format is <c>{&quot;ratio&quot;:1}</c>. <c>abandonRate</c> specifies the target abandon rate, <c>historicalConnectedRate</c> specifies the historical connection rate for reference, and <c>ratio</c> specifies the fixed dialing ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ratio&quot;:1}</para>
            /// </summary>
            [NameInMap("StrategyParameters")]
            [Validation(Required=false)]
            public string StrategyParameters { get; set; }

            /// <summary>
            /// <para>The dialing strategy for the predictive outbound campaign.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PACING</para>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// <para>The total number of contacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCases")]
            [Validation(Required=false)]
            public long? TotalCases { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CCEF32F-8614-535F-A1D9-D85B8C0DC4F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
