// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListEmrHiveAuditLogsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEmrHiveAuditLogsResponseBodyData Data { get; set; }
        public class ListEmrHiveAuditLogsResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("PagedData")]
            [Validation(Required=false)]
            public List<ListEmrHiveAuditLogsResponseBodyDataPagedData> PagedData { get; set; }
            public class ListEmrHiveAuditLogsResponseBodyDataPagedData : TeaModel {
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public long? EventTime { get; set; }

                [NameInMap("Groups")]
                [Validation(Required=false)]
                public List<string> Groups { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
