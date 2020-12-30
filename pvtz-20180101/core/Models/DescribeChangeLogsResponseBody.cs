// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeChangeLogsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ChangeLogs")]
        [Validation(Required=false)]
        public DescribeChangeLogsResponseBodyChangeLogs ChangeLogs { get; set; }
        public class DescribeChangeLogsResponseBodyChangeLogs : TeaModel {
            [NameInMap("ChangeLog")]
            [Validation(Required=false)]
            public List<DescribeChangeLogsResponseBodyChangeLogsChangeLog> ChangeLog { get; set; }
            public class DescribeChangeLogsResponseBodyChangeLogsChangeLog : TeaModel {
                public long? OperTimestamp { get; set; }
                public string EntityId { get; set; }
                public string OperObject { get; set; }
                public string OperTime { get; set; }
                public string OperIp { get; set; }
                public string OperAction { get; set; }
                public string Content { get; set; }
                public string EntityName { get; set; }
                public long? Id { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

    }

}
