// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetSuspEventSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSuspEventSummaryResponseBodyData Data { get; set; }
        public class GetSuspEventSummaryResponseBodyData : TeaModel {
            [NameInMap("NetworkAttackTrendDTO")]
            [Validation(Required=false)]
            public GetSuspEventSummaryResponseBodyDataNetworkAttackTrendDTO NetworkAttackTrendDTO { get; set; }
            public class GetSuspEventSummaryResponseBodyDataNetworkAttackTrendDTO : TeaModel {
                [NameInMap("TrendList")]
                [Validation(Required=false)]
                public List<GetSuspEventSummaryResponseBodyDataNetworkAttackTrendDTOTrendList> TrendList { get; set; }
                public class GetSuspEventSummaryResponseBodyDataNetworkAttackTrendDTOTrendList : TeaModel {
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("DdosCount")]
                    [Validation(Required=false)]
                    public long? DdosCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("EipCount")]
                    [Validation(Required=false)]
                    public long? EipCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("WafCount")]
                    [Validation(Required=false)]
                    public long? WafCount { get; set; }

                }

            }

            [NameInMap("SuspEventDealSummaryDTO")]
            [Validation(Required=false)]
            public GetSuspEventSummaryResponseBodyDataSuspEventDealSummaryDTO SuspEventDealSummaryDTO { get; set; }
            public class GetSuspEventSummaryResponseBodyDataSuspEventDealSummaryDTO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("CompletedCount")]
                [Validation(Required=false)]
                public long? CompletedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("HandingCount")]
                [Validation(Required=false)]
                public long? HandingCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("HandingRate")]
                [Validation(Required=false)]
                public string HandingRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>35</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalGrowthRate")]
                [Validation(Required=false)]
                public string TotalGrowthRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WaitHandleCount")]
                [Validation(Required=false)]
                public long? WaitHandleCount { get; set; }

            }

            [NameInMap("SuspEventTopDTO")]
            [Validation(Required=false)]
            public GetSuspEventSummaryResponseBodyDataSuspEventTopDTO SuspEventTopDTO { get; set; }
            public class GetSuspEventSummaryResponseBodyDataSuspEventTopDTO : TeaModel {
                [NameInMap("SuspEventList")]
                [Validation(Required=false)]
                public List<GetSuspEventSummaryResponseBodyDataSuspEventTopDTOSuspEventList> SuspEventList { get; set; }
                public class GetSuspEventSummaryResponseBodyDataSuspEventTopDTOSuspEventList : TeaModel {
                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("TaskCount")]
                    [Validation(Required=false)]
                    public long? TaskCount { get; set; }

                }

            }

            [NameInMap("SuspEventTrendDTO")]
            [Validation(Required=false)]
            public GetSuspEventSummaryResponseBodyDataSuspEventTrendDTO SuspEventTrendDTO { get; set; }
            public class GetSuspEventSummaryResponseBodyDataSuspEventTrendDTO : TeaModel {
                [NameInMap("TrendList")]
                [Validation(Required=false)]
                public List<GetSuspEventSummaryResponseBodyDataSuspEventTrendDTOTrendList> TrendList { get; set; }
                public class GetSuspEventSummaryResponseBodyDataSuspEventTrendDTOTrendList : TeaModel {
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("DealCount")]
                    [Validation(Required=false)]
                    public long? DealCount { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2DAE9B-B901-5818-AFEF-E5637D938280</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
