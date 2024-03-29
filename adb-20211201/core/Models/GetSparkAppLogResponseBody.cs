// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppLogResponseBody : TeaModel {
        /// <summary>
        /// The queried log.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppLogResponseBodyData Data { get; set; }
        public class GetSparkAppLogResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Data Lakehouse Edition (V3.0) cluster.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The content of the log.
            /// </summary>
            [NameInMap("LogContent")]
            [Validation(Required=false)]
            public string LogContent { get; set; }

            /// <summary>
            /// The number of log entries. A value of 0 indicates that no valid logs are returned.
            /// </summary>
            [NameInMap("LogSize")]
            [Validation(Required=false)]
            public int? LogSize { get; set; }

            /// <summary>
            /// The alert message returned for the request, such as task execution failure or insufficient resources. If no alert occurs, null is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
