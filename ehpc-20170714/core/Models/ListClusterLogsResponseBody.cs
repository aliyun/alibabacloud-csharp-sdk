// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class ListClusterLogsResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Logs")]
        [Validation(Required=false)]
        public ListClusterLogsResponseBodyLogs Logs { get; set; }
        public class ListClusterLogsResponseBodyLogs : TeaModel {
            [NameInMap("LogInfo")]
            [Validation(Required=false)]
            public List<ListClusterLogsResponseBodyLogsLogInfo> LogInfo { get; set; }
            public class ListClusterLogsResponseBodyLogsLogInfo : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
