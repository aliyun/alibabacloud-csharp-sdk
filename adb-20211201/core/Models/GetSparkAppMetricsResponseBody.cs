// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppMetricsResponseBodyData Data { get; set; }
        public class GetSparkAppMetricsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202302051515shfa865f8000****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The retry ID of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202301061000hz57d797b0000201-****</para>
            /// </summary>
            [NameInMap("AttemptId")]
            [Validation(Required=false)]
            public string AttemptId { get; set; }

            /// <summary>
            /// <para>The path of the event log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://path/to/eventLog</para>
            /// </summary>
            [NameInMap("EventLogPath")]
            [Validation(Required=false)]
            public string EventLogPath { get; set; }

            /// <summary>
            /// <para>Indicates whether the parsing is completed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Completed.</description></item>
            /// <item><description><b>false</b>: Not completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            /// <summary>
            /// <para>The metric data.</para>
            /// </summary>
            [NameInMap("ScanMetrics")]
            [Validation(Required=false)]
            public GetSparkAppMetricsResponseBodyDataScanMetrics ScanMetrics { get; set; }
            public class GetSparkAppMetricsResponseBodyDataScanMetrics : TeaModel {
                /// <summary>
                /// <para>The number of scanned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("OutputRowsCount")]
                [Validation(Required=false)]
                public long? OutputRowsCount { get; set; }

                /// <summary>
                /// <para>The size of the scanned data in bytes.</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
