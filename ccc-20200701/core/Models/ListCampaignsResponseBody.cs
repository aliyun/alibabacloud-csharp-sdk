// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCampaignsResponseBody : TeaModel {
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
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCampaignsResponseBodyData Data { get; set; }
        public class ListCampaignsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of predictive dialing campaigns.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCampaignsResponseBodyDataList> List { get; set; }
            public class ListCampaignsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The actual end time of the predictive dialing campaign. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634008800000</para>
                /// </summary>
                [NameInMap("ActualEndTime")]
                [Validation(Required=false)]
                public long? ActualEndTime { get; set; }

                /// <summary>
                /// <para>The actual start time of the predictive dialing campaign. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634000460000</para>
                /// </summary>
                [NameInMap("ActualStartTime")]
                [Validation(Required=false)]
                public long? ActualStartTime { get; set; }

                /// <summary>
                /// <para>The ID of the predictive dialing campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6badb397-a8b5-40b6-21019d382a09</para>
                /// </summary>
                [NameInMap("CampaignId")]
                [Validation(Required=false)]
                public string CampaignId { get; set; }

                /// <summary>
                /// <para>The number of aborted cases in the predictive dialing campaign. An aborted case indicates that the call to the contact was canceled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CasesAborted")]
                [Validation(Required=false)]
                public long? CasesAborted { get; set; }

                /// <summary>
                /// <para>The number of connected cases in the predictive dialing campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("CasesConnected")]
                [Validation(Required=false)]
                public long? CasesConnected { get; set; }

                /// <summary>
                /// <para>The number of uncompleted cases in the predictive dialing campaign. An uncompleted case indicates that the call was not connected and the maximum number of retry attempts was not reached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CasesUncompleted")]
                [Validation(Required=false)]
                public long? CasesUncompleted { get; set; }

                /// <summary>
                /// <para>The completion rate. This parameter is deprecated. You can calculate the completion rate by using the formula (TotalCases - CasesUnCompleted) / TotalCases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("CompletionRate")]
                [Validation(Required=false)]
                public float? CompletionRate { get; set; }

                /// <summary>
                /// <para>The ID of the IVR contact flow associated with the phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a3fb6c62-9b49-4942-ae5b-cf2abd4123ek</para>
                /// </summary>
                [NameInMap("ContactFlowId")]
                [Validation(Required=false)]
                public string ContactFlowId { get; set; }

                /// <summary>
                /// <para>The maximum number of attempts for the predictive dialing campaign. This value specifies the maximum number of redial attempts when a call to a number fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxAttemptCount")]
                [Validation(Required=false)]
                public long? MaxAttemptCount { get; set; }

                /// <summary>
                /// <para>The minimum redial interval for the predictive dialing campaign. This value specifies the minimum interval between redial attempts after a failure. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public long? MinAttemptInterval { get; set; }

                /// <summary>
                /// <para>The name of the predictive dialing campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-campaign</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The planned end time of the predictive dialing campaign. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634054400000</para>
                /// </summary>
                [NameInMap("PlanedEndTime")]
                [Validation(Required=false)]
                public long? PlanedEndTime { get; set; }

                /// <summary>
                /// <para>The planned start time of the predictive dialing campaign. The value is a UNIX timestamp in milliseconds.</para>
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
                /// <para>The name of the skill group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试技能组</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>Indicates whether the campaign is a simulated campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Simulation")]
                [Validation(Required=false)]
                public bool? Simulation { get; set; }

                /// <summary>
                /// <para>The state of the predictive dialing campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Completed</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The strategy parameters of the predictive dialing campaign. Example for the PID strategy: {&quot;abandonRate&quot;:&quot;5&quot;,&quot;historicalConnectedRate&quot;:&quot;35&quot;}. Example for the PACING strategy: {&quot;ratio&quot;:1}. abandonRate specifies the expected call abandon rate. historicalConnectedRate specifies the historical reference connection rate. ratio specifies the fixed dialing ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;ratio&quot;:1}</para>
                /// </summary>
                [NameInMap("StrategyParameters")]
                [Validation(Required=false)]
                public string StrategyParameters { get; set; }

                /// <summary>
                /// <para>The strategy mode of the predictive dialing campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PACING</para>
                /// </summary>
                [NameInMap("StrategyType")]
                [Validation(Required=false)]
                public string StrategyType { get; set; }

                /// <summary>
                /// <para>The total number of phone numbers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCases")]
                [Validation(Required=false)]
                public long? TotalCases { get; set; }

            }

            /// <summary>
            /// <para>The page number. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CCEF32F-8614-535F-A1D9-D85B8C0DC4F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
