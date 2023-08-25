// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkSQLEngineStateResponseBody : TeaModel {
        /// <summary>
        /// The state information about the Spark SQL engine.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkSQLEngineStateResponseBodyData Data { get; set; }
        public class GetSparkSQLEngineStateResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Spark application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The configuration of the Spark application.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The third-party JAR package.
            /// </summary>
            [NameInMap("Jars")]
            [Validation(Required=false)]
            public string Jars { get; set; }

            /// <summary>
            /// The maximum number of started Spark executors.
            /// </summary>
            [NameInMap("MaxExecutor")]
            [Validation(Required=false)]
            public string MaxExecutor { get; set; }

            /// <summary>
            /// The minimum number of started Spark executors.
            /// </summary>
            [NameInMap("MinExecutor")]
            [Validation(Required=false)]
            public string MinExecutor { get; set; }

            /// <summary>
            /// The slot number of the Spark application.
            /// </summary>
            [NameInMap("SlotNum")]
            [Validation(Required=false)]
            public string SlotNum { get; set; }

            /// <summary>
            /// The execution state of the application. Valid values:
            /// 
            /// *   SUBMITTED
            /// *   STARTING
            /// *   RUNNING
            /// *   FAILING
            /// *   FAILED
            /// *   KILLING
            /// *   KILLED
            /// *   SUCCEEDING
            /// *   COMPLETED
            /// *   FATAL
            /// *   UNKNOWN
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The timestamp when the Spark SQL application was submitted. Unit: milliseconds.
            /// </summary>
            [NameInMap("SubmittedTimeInMillis")]
            [Validation(Required=false)]
            public string SubmittedTimeInMillis { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
