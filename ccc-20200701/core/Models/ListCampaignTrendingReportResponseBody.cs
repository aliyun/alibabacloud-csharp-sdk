// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCampaignTrendingReportResponseBody : TeaModel {
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
        /// <para>List of statistical data points.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCampaignTrendingReportResponseBodyData> Data { get; set; }
        public class ListCampaignTrendingReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Number of agents on break.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BreakAgents")]
            [Validation(Required=false)]
            public long? BreakAgents { get; set; }

            /// <summary>
            /// <para>Number of agents in break status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BreakingAgents")]
            [Validation(Required=false)]
            public long? BreakingAgents { get; set; }

            /// <summary>
            /// <para>The concurrent call volume, which refers to the number of simultaneous outbound calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public long? Concurrency { get; set; }

            /// <summary>
            /// <para>The timestamp for segmented statistics, formatted as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634037840000</para>
            /// </summary>
            [NameInMap("Datetime")]
            [Validation(Required=false)]
            public long? Datetime { get; set; }

            /// <summary>
            /// <para>The number of published agents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("LoggedInAgents")]
            [Validation(Required=false)]
            public long? LoggedInAgents { get; set; }

            /// <summary>
            /// <para>The number of agents in outbound-only mode who are on a break.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OutboundScenarioBreakingAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioBreakingAgents { get; set; }

            /// <summary>
            /// <para>Number of agents in idle status under outbound-only mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OutboundScenarioReadyAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioReadyAgents { get; set; }

            /// <summary>
            /// <para>The number of agents in outbound-only mode who are currently on a call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OutboundScenarioTalkingAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioTalkingAgents { get; set; }

            /// <summary>
            /// <para>Number of agents in post-processing status under outbound-only mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OutboundScenarioWorkingAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioWorkingAgents { get; set; }

            /// <summary>
            /// <para>Number of idle agents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ReadyAgents")]
            [Validation(Required=false)]
            public long? ReadyAgents { get; set; }

            /// <summary>
            /// <para>Time of the statistical data point, formatted as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1604639129000</para>
            /// </summary>
            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

            /// <summary>
            /// <para>Deprecated. Refer to TalkAgents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TalkAgents")]
            [Validation(Required=false)]
            public long? TalkAgents { get; set; }

            /// <summary>
            /// <para>The number of agents in a call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TalkingAgents")]
            [Validation(Required=false)]
            public long? TalkingAgents { get; set; }

            /// <summary>
            /// <para>Deprecated. Refer to WorkingAgents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WorkAgents")]
            [Validation(Required=false)]
            public long? WorkAgents { get; set; }

            /// <summary>
            /// <para>Number of agents in post-processing status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WorkingAgents")]
            [Validation(Required=false)]
            public long? WorkingAgents { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CCEF32F-8614-535F-A1D9-D85B8C0DC4F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
