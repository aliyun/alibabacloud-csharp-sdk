// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetHistoricalCampaignReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHistoricalCampaignReportResponseBodyData Data { get; set; }
        public class GetHistoricalCampaignReportResponseBodyData : TeaModel {
            [NameInMap("AbandonRate")]
            [Validation(Required=false)]
            public float? AbandonRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.10</para>
            /// </summary>
            [NameInMap("AbandonedRate")]
            [Validation(Required=false)]
            public float? AbandonedRate { get; set; }

            [NameInMap("AnswerRate")]
            [Validation(Required=false)]
            public float? AnswerRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CallsAbandoned")]
            [Validation(Required=false)]
            public long? CallsAbandoned { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("CallsConnected")]
            [Validation(Required=false)]
            public long? CallsConnected { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CallsDialed")]
            [Validation(Required=false)]
            public long? CallsDialed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.50</para>
            /// </summary>
            [NameInMap("ConnectedRate")]
            [Validation(Required=false)]
            public float? ConnectedRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.50</para>
            /// </summary>
            [NameInMap("OccupancyRate")]
            [Validation(Required=false)]
            public float? OccupancyRate { get; set; }

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
        /// <para>E3A847C1-9800-57DF-9172-2CDDC026388D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
