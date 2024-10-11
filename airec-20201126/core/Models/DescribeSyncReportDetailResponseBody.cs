// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DescribeSyncReportDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>An internal server error occurred</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeSyncReportDetailResponseBodyResult> Result { get; set; }
        public class DescribeSyncReportDetailResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("defaultDisplay")]
            [Validation(Required=false)]
            public bool? DefaultDisplay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>246165</para>
            /// </summary>
            [NameInMap("errorCount")]
            [Validation(Required=false)]
            public int? ErrorCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>84.6</para>
            /// </summary>
            [NameInMap("errorPercent")]
            [Validation(Required=false)]
            public float? ErrorPercent { get; set; }

            [NameInMap("historyData")]
            [Validation(Required=false)]
            public List<DescribeSyncReportDetailResponseBodyResultHistoryData> HistoryData { get; set; }
            public class DescribeSyncReportDetailResponseBodyResultHistoryData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1586673466</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>84.6</para>
                /// </summary>
                [NameInMap("errorPercent")]
                [Validation(Required=false)]
                public float? ErrorPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1586673466</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sampleDisplay")]
            [Validation(Required=false)]
            public bool? SampleDisplay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bhvTimeBehavior</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
