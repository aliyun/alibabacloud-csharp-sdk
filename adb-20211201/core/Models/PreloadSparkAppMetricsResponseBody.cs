// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class PreloadSparkAppMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PreloadSparkAppMetricsResponseBodyData Data { get; set; }
        public class PreloadSparkAppMetricsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202212181815shaccb8be0000253</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The retry ID of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202301061000hz57d797b0000201-0001</para>
            /// </summary>
            [NameInMap("AttemptId")]
            [Validation(Required=false)]
            public string AttemptId { get; set; }

            /// <summary>
            /// <para>The event log path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://path/to/eventLog</para>
            /// </summary>
            [NameInMap("EventLogPath")]
            [Validation(Required=false)]
            public string EventLogPath { get; set; }

            /// <summary>
            /// <para>Indicates whether parsing is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            /// <summary>
            /// <para>The metrics.</para>
            /// </summary>
            [NameInMap("ScanMetrics")]
            [Validation(Required=false)]
            public PreloadSparkAppMetricsResponseBodyDataScanMetrics ScanMetrics { get; set; }
            public class PreloadSparkAppMetricsResponseBodyDataScanMetrics : TeaModel {
                /// <summary>
                /// <para>The number of rows scanned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("OutputRowsCount")]
                [Validation(Required=false)]
                public long? OutputRowsCount { get; set; }

                /// <summary>
                /// <para>The size of the scanned data. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("TotalReadFileSizeInByte")]
                [Validation(Required=false)]
                public long? TotalReadFileSizeInByte { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84489769-3065-5A28-A4CB-977CD426F1C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
