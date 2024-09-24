// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorDataListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>end timestamp must not be before start time.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C240412F-3F5F-50E2-ACEC-DE808EF9C4BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The returned monitoring data.</para>
        /// </summary>
        [NameInMap("TimeSeries")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorDataListResponseBodyTimeSeries> TimeSeries { get; set; }
        public class DescribeHybridMonitorDataListResponseBodyTimeSeries : TeaModel {
            /// <summary>
            /// <para>The tags of the time dimension.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorDataListResponseBodyTimeSeriesLabels> Labels { get; set; }
            public class DescribeHybridMonitorDataListResponseBodyTimeSeriesLabels : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instanceId</para>
                /// </summary>
                [NameInMap("K")]
                [Validation(Required=false)]
                public string K { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-rj99xc6cptkk64ml****</para>
                /// </summary>
                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunEcs_cpu_total</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The metric values that are collected at different timestamps.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorDataListResponseBodyTimeSeriesValues> Values { get; set; }
            public class DescribeHybridMonitorDataListResponseBodyTimeSeriesValues : TeaModel {
                /// <summary>
                /// <para>The timestamp that indicates the time when the metric value is collected.</para>
                /// <para>Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1653804865</para>
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public string Ts { get; set; }

                /// <summary>
                /// <para>The metric value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.13</para>
                /// </summary>
                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

        }

    }

}
