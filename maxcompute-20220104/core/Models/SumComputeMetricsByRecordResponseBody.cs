// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumComputeMetricsByRecordResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumComputeMetricsByRecordResponseBodyData> Data { get; set; }
        public class SumComputeMetricsByRecordResponseBodyData : TeaModel {
            [NameInMap("dailyComputeRecords")]
            [Validation(Required=false)]
            public List<SumComputeMetricsByRecordResponseBodyDataDailyComputeRecords> DailyComputeRecords { get; set; }
            public class SumComputeMetricsByRecordResponseBodyDataDailyComputeRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20260411</para>
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("record")]
                [Validation(Required=false)]
                public string Record { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ComputationSql</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0a06dfe517540143853845404e83af</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
