// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetWorkTaskSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkTaskSummaryResponseBodyData Data { get; set; }
        public class GetWorkTaskSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("DealAverageDuration")]
            [Validation(Required=false)]
            public long? DealAverageDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DealAverageDurationGrowthRate")]
            [Validation(Required=false)]
            public string DealAverageDurationGrowthRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DealWorkTaskCount")]
            [Validation(Required=false)]
            public long? DealWorkTaskCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DealWorkTaskCountRate")]
            [Validation(Required=false)]
            public string DealWorkTaskCountRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WorkTaskCount")]
            [Validation(Required=false)]
            public long? WorkTaskCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("WorkTaskDealRate")]
            [Validation(Required=false)]
            public string WorkTaskDealRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("WorkTaskDealRateGrowthRate")]
            [Validation(Required=false)]
            public string WorkTaskDealRateGrowthRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("WorkTaskGrowthRate")]
            [Validation(Required=false)]
            public string WorkTaskGrowthRate { get; set; }

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
        /// <para>EF801DD1-D934-51B3-92D4-776CE17B184F</para>
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
