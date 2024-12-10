// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetSuspEventSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>API response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the interface.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSuspEventSummaryResponseBodyData Data { get; set; }
        public class GetSuspEventSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Network attack trend.</para>
            /// </summary>
            [NameInMap("NetworkAttackTrendDTO")]
            [Validation(Required=false)]
            public GetSuspEventSummaryResponseBodyDataNetworkAttackTrendDTO NetworkAttackTrendDTO { get; set; }
            public class GetSuspEventSummaryResponseBodyDataNetworkAttackTrendDTO : TeaModel {
                /// <summary>
                /// <para>Collection of trend nodes for each attack item.</para>
                /// </summary>
                [NameInMap("TrendList")]
                [Validation(Required=false)]
                public List<GetSuspEventSummaryResponseBodyDataNetworkAttackTrendDTOTrendList> TrendList { get; set; }
                public class GetSuspEventSummaryResponseBodyDataNetworkAttackTrendDTOTrendList : TeaModel {
                    /// <summary>
                    /// <para>Date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>202409或20240901</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <para>DDoS count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("DdosCount")]
                    [Validation(Required=false)]
                    public long? DdosCount { get; set; }

                    /// <summary>
                    /// <para>EIP count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("EipCount")]
                    [Validation(Required=false)]
                    public long? EipCount { get; set; }

                    /// <summary>
                    /// <para>WAF count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("WafCount")]
                    [Validation(Required=false)]
                    public long? WafCount { get; set; }

                }

            }

            /// <summary>
            /// <para>Overview of alert handling.</para>
            /// </summary>
            [NameInMap("SuspEventDealSummaryDTO")]
            [Validation(Required=false)]
            public GetSuspEventSummaryResponseBodyDataSuspEventDealSummaryDTO SuspEventDealSummaryDTO { get; set; }
            public class GetSuspEventSummaryResponseBodyDataSuspEventDealSummaryDTO : TeaModel {
                /// <summary>
                /// <para>Completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("CompletedCount")]
                [Validation(Required=false)]
                public long? CompletedCount { get; set; }

                /// <summary>
                /// <para>In progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("HandingCount")]
                [Validation(Required=false)]
                public long? HandingCount { get; set; }

                /// <summary>
                /// <para>Alert handling rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("HandingRate")]
                [Validation(Required=false)]
                public string HandingRate { get; set; }

                /// <summary>
                /// <para>Total number of alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                /// <summary>
                /// <para>Year-over-year comparison of alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalGrowthRate")]
                [Validation(Required=false)]
                public string TotalGrowthRate { get; set; }

                /// <summary>
                /// <para>Number of unhandled alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WaitHandleCount")]
                [Validation(Required=false)]
                public long? WaitHandleCount { get; set; }

            }

            /// <summary>
            /// <para>Top 10 alerts before handling.</para>
            /// </summary>
            [NameInMap("SuspEventTopDTO")]
            [Validation(Required=false)]
            public GetSuspEventSummaryResponseBodyDataSuspEventTopDTO SuspEventTopDTO { get; set; }
            public class GetSuspEventSummaryResponseBodyDataSuspEventTopDTO : TeaModel {
                /// <summary>
                /// <para>Top 10 before handling alarms</para>
                /// </summary>
                [NameInMap("SuspEventList")]
                [Validation(Required=false)]
                public List<GetSuspEventSummaryResponseBodyDataSuspEventTopDTOSuspEventList> SuspEventList { get; set; }
                public class GetSuspEventSummaryResponseBodyDataSuspEventTopDTOSuspEventList : TeaModel {
                    /// <summary>
                    /// <para>Alert name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>主动外连风险 IP</para>
                    /// </summary>
                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    /// <summary>
                    /// <para>Count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("TaskCount")]
                    [Validation(Required=false)]
                    public long? TaskCount { get; set; }

                }

            }

            /// <summary>
            /// <para>Trend of alert responses.</para>
            /// </summary>
            [NameInMap("SuspEventTrendDTO")]
            [Validation(Required=false)]
            public GetSuspEventSummaryResponseBodyDataSuspEventTrendDTO SuspEventTrendDTO { get; set; }
            public class GetSuspEventSummaryResponseBodyDataSuspEventTrendDTO : TeaModel {
                /// <summary>
                /// <para>Trend of alerts.</para>
                /// </summary>
                [NameInMap("TrendList")]
                [Validation(Required=false)]
                public List<GetSuspEventSummaryResponseBodyDataSuspEventTrendDTOTrendList> TrendList { get; set; }
                public class GetSuspEventSummaryResponseBodyDataSuspEventTrendDTOTrendList : TeaModel {
                    /// <summary>
                    /// <para>Time point.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>202405或者20240501</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <para>Number of handled alerts.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("DealCount")]
                    [Validation(Required=false)]
                    public long? DealCount { get; set; }

                    /// <summary>
                    /// <para>Number of discovered alerts.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15</para>
                    /// </summary>
                    [NameInMap("FindCount")]
                    [Validation(Required=false)]
                    public long? FindCount { get; set; }

                }

            }

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
        /// <para>Prompt message for the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2DAE9B-B901-5818-AFEF-E5637D938280</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description>true: Call succeeded.</description></item>
        /// <item><description>false: Call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
