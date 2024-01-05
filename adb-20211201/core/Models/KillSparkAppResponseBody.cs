// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class KillSparkAppResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public KillSparkAppResponseBodyData Data { get; set; }
        public class KillSparkAppResponseBodyData : TeaModel {
            /// <summary>
            /// The Spark application ID.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The error message returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The execution state of the Spark application. Valid values:
            /// 
            /// *   **SUBMITTED**
            /// *   **STARTING**
            /// *   **RUNNING**
            /// *   **FAILING**
            /// *   **FAILED**
            /// *   **KILLING**
            /// *   **KILLED**
            /// *   **SUCCEEDING**
            /// *   **COMPLETED**
            /// *   **FATAL**
            /// *   **UNKNOWN**
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
