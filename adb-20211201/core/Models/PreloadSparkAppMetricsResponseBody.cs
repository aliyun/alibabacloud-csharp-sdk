// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class PreloadSparkAppMetricsResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PreloadSparkAppMetricsResponseBodyData Data { get; set; }
        public class PreloadSparkAppMetricsResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Spark application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The retry ID of the Spark application.
            /// </summary>
            [NameInMap("AttemptId")]
            [Validation(Required=false)]
            public string AttemptId { get; set; }

            /// <summary>
            /// The event log path.
            /// </summary>
            [NameInMap("EventLogPath")]
            [Validation(Required=false)]
            public string EventLogPath { get; set; }

            /// <summary>
            /// Indicates whether parsing is complete. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            /// <summary>
            /// The metrics.
            /// </summary>
            [NameInMap("ScanMetrics")]
            [Validation(Required=false)]
            public PreloadSparkAppMetricsResponseBodyDataScanMetrics ScanMetrics { get; set; }
            public class PreloadSparkAppMetricsResponseBodyDataScanMetrics : TeaModel {
                /// <summary>
                /// The number of rows scanned.
                /// </summary>
                [NameInMap("OutputRowsCount")]
                [Validation(Required=false)]
                public long? OutputRowsCount { get; set; }

                /// <summary>
                /// The size of the scanned data. Unit: bytes.
                /// </summary>
                [NameInMap("TotalReadFileSizeInByte")]
                [Validation(Required=false)]
                public long? TotalReadFileSizeInByte { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
