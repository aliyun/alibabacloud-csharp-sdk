// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmLogsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("Logs")]
        [Validation(Required=false)]
        public DescribeGtmLogsResponseBodyLogs Logs { get; set; }
        public class DescribeGtmLogsResponseBodyLogs : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<DescribeGtmLogsResponseBodyLogsLog> Log { get; set; }
            public class DescribeGtmLogsResponseBodyLogsLog : TeaModel {
                public long? OperTimestamp { get; set; }
                public string EntityId { get; set; }
                public string EntityType { get; set; }
                public string OperTime { get; set; }
                public string OperIp { get; set; }
                public string OperAction { get; set; }
                public string Content { get; set; }
                public string EntityName { get; set; }
                public long? Id { get; set; }
            }
        };

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

    }

}
