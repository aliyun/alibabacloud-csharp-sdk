// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClusterLogsResponseBody : TeaModel {
        /// <summary>
        /// The details of operations logs.
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<DescribeHubClusterLogsResponseBodyLogs> Logs { get; set; }
        public class DescribeHubClusterLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// The ID of the Fleet instance.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The log of the Fleet instance.
            /// </summary>
            [NameInMap("ClusterLog")]
            [Validation(Required=false)]
            public string ClusterLog { get; set; }

            /// <summary>
            /// The time when the log was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The log level. Valid values:
            /// 
            /// *   error
            /// *   warn
            /// *   info
            /// </summary>
            [NameInMap("LogLevel")]
            [Validation(Required=false)]
            public string LogLevel { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
