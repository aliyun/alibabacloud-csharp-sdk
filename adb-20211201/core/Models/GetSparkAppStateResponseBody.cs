// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppStateResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppStateResponseBodyData Data { get; set; }
        public class GetSparkAppStateResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the application.
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
            /// The ID of the Database.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The alert message returned for the operation, such as task execution failure or insufficient resources. Null is returned if no alert occurs.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The execution state of the application. Valid values:
            /// 
            /// *   **SUBMITTED**: The application is submitted.
            /// *   **STARTING**: The application task is starting.
            /// *   **RUNNING**: The application task is being executed.
            /// *   **FAILING**: The application task failed, and the environment is being cleared.
            /// *   **FAILED**: The application task failed.
            /// *   **KILLING**: The application task is terminated, and the environment is being cleared.
            /// *   **KILLED**: The application task is terminated.
            /// *   **SUCCEEDING**: The application task is completed, and the environment is being cleared.
            /// *   **COMPLETED**: The application task is completed.
            /// *   **FATAL**: An unexpected failure occurred.
            /// *   **UNKNOWN**: An unknown error occurred.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
