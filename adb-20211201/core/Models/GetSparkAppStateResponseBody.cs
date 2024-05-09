// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppStateResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppStateResponseBodyData Data { get; set; }
        public class GetSparkAppStateResponseBodyData : TeaModel {
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
            /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The alert message returned for the operation, such as task execution failure or insufficient resources. If no alert occurs, null is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The execution state of the application. Valid values:
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
