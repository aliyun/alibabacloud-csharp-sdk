// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetHistoricalCampaignReportResponseBody : TeaModel {
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
        public GetHistoricalCampaignReportResponseBodyData Data { get; set; }
        public class GetHistoricalCampaignReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Abandon rate, calculated as: number of abandoned calls divided by total calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.10</para>
            /// </summary>
            [NameInMap("AbandonRate")]
            [Validation(Required=false)]
            public float? AbandonRate { get; set; }

            /// <summary>
            /// <para>Deprecated. Refer to AbandonRate instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.10</para>
            /// </summary>
            [NameInMap("AbandonedRate")]
            [Validation(Required=false)]
            public float? AbandonedRate { get; set; }

            /// <summary>
            /// <para>Answer rate, in %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.50</para>
            /// </summary>
            [NameInMap("AnswerRate")]
            [Validation(Required=false)]
            public float? AnswerRate { get; set; }

            /// <summary>
            /// <para>Number of abandoned calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CallsAbandoned")]
            [Validation(Required=false)]
            public long? CallsAbandoned { get; set; }

            /// <summary>
            /// <para>Number of connected calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("CallsConnected")]
            [Validation(Required=false)]
            public long? CallsConnected { get; set; }

            /// <summary>
            /// <para>Number of calls dialed, including retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CallsDialed")]
            [Validation(Required=false)]
            public long? CallsDialed { get; set; }

            /// <summary>
            /// <para>Deprecated. Refer to AnswerRate instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.50</para>
            /// </summary>
            [NameInMap("ConnectedRate")]
            [Validation(Required=false)]
            public float? ConnectedRate { get; set; }

            /// <summary>
            /// <para>Agent occupancy rate, calculated as: (total talk duration + total post-processing duration) divided by total agent online duration. Total agent online duration refers to the sum of online durations of all agents in the skill group associated with this activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.50</para>
            /// </summary>
            [NameInMap("OccupancyRate")]
            [Validation(Required=false)]
            public float? OccupancyRate { get; set; }

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
        /// <para>E3A847C1-9800-57DF-9172-2CDDC026388D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
