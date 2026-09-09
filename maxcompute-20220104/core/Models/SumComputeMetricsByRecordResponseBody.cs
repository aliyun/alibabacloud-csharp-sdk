// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumComputeMetricsByRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumComputeMetricsByRecordResponseBodyData> Data { get; set; }
        public class SumComputeMetricsByRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of daily usage records.</para>
            /// </summary>
            [NameInMap("dailyComputeRecords")]
            [Validation(Required=false)]
            public List<SumComputeMetricsByRecordResponseBodyDataDailyComputeRecords> DailyComputeRecords { get; set; }
            public class SumComputeMetricsByRecordResponseBodyDataDailyComputeRecords : TeaModel {
                /// <summary>
                /// <para>The statistics date. The format is yyyyMMdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20260411</para>
                /// </summary>
                [NameInMap("dateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

                /// <summary>
                /// <para>This day\&quot;s usage as a percentage of the total usage for the specified period. The value does not include a percent sign (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                /// <summary>
                /// <para>The record count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("record")]
                [Validation(Required=false)]
                public string Record { get; set; }

            }

            /// <summary>
            /// <para>The usage type. For example: ComputationSql</para>
            /// 
            /// <b>Example:</b>
            /// <para>ComputationSql</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: Informational. The server has received the request and is processing it.</para>
        /// </description></item>
        /// <item><description><para>2xx: Success. The server successfully received, understood, and accepted the request.</para>
        /// </description></item>
        /// <item><description><para>3xx: Redirection. The client must take further action to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: Client-side error. The request contains invalid syntax or parameters and cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para>5xx: Server-side error. The server failed to fulfill a valid request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a06dfe517540143853845404e83af</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
