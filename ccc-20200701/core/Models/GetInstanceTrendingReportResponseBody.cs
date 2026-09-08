// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetInstanceTrendingReportResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceTrendingReportResponseBodyData Data { get; set; }
        public class GetInstanceTrendingReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Inbound metrics.</para>
            /// </summary>
            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public List<GetInstanceTrendingReportResponseBodyDataInbound> Inbound { get; set; }
            public class GetInstanceTrendingReportResponseBodyDataInbound : TeaModel {
                /// <summary>
                /// <para>Number of calls abandoned in the IVR, meaning calls that were abandoned during the IVR flow after entering it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInIVR")]
                [Validation(Required=false)]
                public long? CallsAbandonedInIVR { get; set; }

                /// <summary>
                /// <para>Number of calls abandoned in the queue, meaning calls that were abandoned while waiting in the skill group queue after entering it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInQueue")]
                [Validation(Required=false)]
                public long? CallsAbandonedInQueue { get; set; }

                /// <summary>
                /// <para>Number of calls abandoned during ringing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInRing")]
                [Validation(Required=false)]
                public long? CallsAbandonedInRing { get; set; }

                /// <summary>
                /// <para>Number of calls answered by agents. If a single call is distributed to multiple agents, it is counted as one call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }

                /// <summary>
                /// <para>Number of calls that entered the queue. If a single call enters the queue multiple times, it is counted as one call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueued")]
                [Validation(Required=false)]
                public long? CallsQueued { get; set; }

                /// <summary>
                /// <para>The start time of the segment statistics, in UNIX timestamp format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1604639129000</para>
                /// </summary>
                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

                /// <summary>
                /// <para>Total number of incoming calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }

            }

            /// <summary>
            /// <para>Outbound metrics.</para>
            /// </summary>
            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public List<GetInstanceTrendingReportResponseBodyDataOutbound> Outbound { get; set; }
            public class GetInstanceTrendingReportResponseBodyDataOutbound : TeaModel {
                /// <summary>
                /// <para>Number of answered outbound calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                /// <summary>
                /// <para>Start time of the segment, in UNIX timestamp format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1604639129000</para>
                /// </summary>
                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

                /// <summary>
                /// <para>Total number of outbound calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }

            }

            /// <summary>
            /// <para>Overall metrics.</para>
            /// </summary>
            [NameInMap("Overall")]
            [Validation(Required=false)]
            public List<GetInstanceTrendingReportResponseBodyDataOverall> Overall { get; set; }
            public class GetInstanceTrendingReportResponseBodyDataOverall : TeaModel {
                /// <summary>
                /// <para>Maximum number of agents logged on simultaneously during this time range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102</para>
                /// </summary>
                [NameInMap("MaxLoggedInAgents")]
                [Validation(Required=false)]
                public long? MaxLoggedInAgents { get; set; }

                /// <summary>
                /// <para>The start time of the segment statistics, in UNIX timestamp format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1604639129000</para>
                /// </summary>
                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

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
        /// <para>943D8EF3-3321-471F-A104-51C96FCA94D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
