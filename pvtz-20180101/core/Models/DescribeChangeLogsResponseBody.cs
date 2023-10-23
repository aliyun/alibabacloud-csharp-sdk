// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeChangeLogsResponseBody : TeaModel {
        [NameInMap("ChangeLogs")]
        [Validation(Required=false)]
        public DescribeChangeLogsResponseBodyChangeLogs ChangeLogs { get; set; }
        public class DescribeChangeLogsResponseBodyChangeLogs : TeaModel {
            [NameInMap("ChangeLog")]
            [Validation(Required=false)]
            public List<DescribeChangeLogsResponseBodyChangeLogsChangeLog> ChangeLog { get; set; }
            public class DescribeChangeLogsResponseBodyChangeLogsChangeLog : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("EntityName")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("OperAction")]
                [Validation(Required=false)]
                public string OperAction { get; set; }

                [NameInMap("OperIp")]
                [Validation(Required=false)]
                public string OperIp { get; set; }

                [NameInMap("OperObject")]
                [Validation(Required=false)]
                public string OperObject { get; set; }

                [NameInMap("OperTime")]
                [Validation(Required=false)]
                public string OperTime { get; set; }

                [NameInMap("OperTimestamp")]
                [Validation(Required=false)]
                public long? OperTimestamp { get; set; }

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

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
