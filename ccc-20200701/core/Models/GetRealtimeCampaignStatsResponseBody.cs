// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetRealtimeCampaignStatsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRealtimeCampaignStatsResponseBodyData Data { get; set; }
        public class GetRealtimeCampaignStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BreakingAgents")]
            [Validation(Required=false)]
            public long? BreakingAgents { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Caps")]
            [Validation(Required=false)]
            public long? Caps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
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
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReadyAgents")]
            [Validation(Required=false)]
            public long? ReadyAgents { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TalkingAgents")]
            [Validation(Required=false)]
            public long? TalkingAgents { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalAgents")]
            [Validation(Required=false)]
            public long? TotalAgents { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
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
        /// <para>42970829-E2C8-515A-8F42-5A6B59F852A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
