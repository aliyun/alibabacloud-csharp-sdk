// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClusterLogsResponseBody : TeaModel {
        /// <summary>
        /// Brief information about operation logs.
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<DescribeHubClusterLogsResponseBodyLogs> Logs { get; set; }
        public class DescribeHubClusterLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// The ID of the master instance.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// A log of the master instance.
            /// </summary>
            [NameInMap("ClusterLog")]
            [Validation(Required=false)]
            public string ClusterLog { get; set; }

            /// <summary>
            /// The time when the log was created. Format: <i>yyyy-mm-dd</i>t<i>hh:mm:ss</i>z (UTC time).
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The severity level of the log. Valid values: - error: errors. - warn: warnings. - info: information.
            /// </summary>
            [NameInMap("LogLevel")]
            [Validation(Required=false)]
            public string LogLevel { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
