// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClusterLogsResponseBody : TeaModel {
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<DescribeHubClusterLogsResponseBodyLogs> Logs { get; set; }
        public class DescribeHubClusterLogsResponseBodyLogs : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterLog")]
            [Validation(Required=false)]
            public string ClusterLog { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("LogLevel")]
            [Validation(Required=false)]
            public string LogLevel { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
