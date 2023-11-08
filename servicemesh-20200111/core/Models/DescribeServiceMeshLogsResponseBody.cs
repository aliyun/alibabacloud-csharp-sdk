// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshLogsResponseBody : TeaModel {
        /// <summary>
        /// The details of the logs.
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshLogsResponseBodyLogs> Logs { get; set; }
        public class DescribeServiceMeshLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// The point in time when the logs were generated.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The content of the logs.
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            /// <summary>
            /// The ASM instance ID.
            /// </summary>
            [NameInMap("ServiceMeshId")]
            [Validation(Required=false)]
            public string ServiceMeshId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
