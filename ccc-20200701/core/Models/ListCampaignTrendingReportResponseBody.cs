// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCampaignTrendingReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCampaignTrendingReportResponseBodyData> Data { get; set; }
        public class ListCampaignTrendingReportResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BreakAgents")]
            [Validation(Required=false)]
            public long? BreakAgents { get; set; }

            [NameInMap("BreakingAgents")]
            [Validation(Required=false)]
            public long? BreakingAgents { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public long? Concurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1634037840000</para>
            /// </summary>
            [NameInMap("Datetime")]
            [Validation(Required=false)]
            public long? Datetime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("LoggedInAgents")]
            [Validation(Required=false)]
            public long? LoggedInAgents { get; set; }

            [NameInMap("OutboundScenarioBreakingAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioBreakingAgents { get; set; }

            [NameInMap("OutboundScenarioReadyAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioReadyAgents { get; set; }

            [NameInMap("OutboundScenarioTalkingAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioTalkingAgents { get; set; }

            [NameInMap("OutboundScenarioWorkingAgents")]
            [Validation(Required=false)]
            public long? OutboundScenarioWorkingAgents { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ReadyAgents")]
            [Validation(Required=false)]
            public long? ReadyAgents { get; set; }

            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TalkAgents")]
            [Validation(Required=false)]
            public long? TalkAgents { get; set; }

            [NameInMap("TalkingAgents")]
            [Validation(Required=false)]
            public long? TalkingAgents { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WorkAgents")]
            [Validation(Required=false)]
            public long? WorkAgents { get; set; }

            [NameInMap("WorkingAgents")]
            [Validation(Required=false)]
            public long? WorkingAgents { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6CCEF32F-8614-535F-A1D9-D85B8C0DC4F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
