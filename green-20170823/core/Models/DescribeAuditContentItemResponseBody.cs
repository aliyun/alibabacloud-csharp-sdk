// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeAuditContentItemResponseBody : TeaModel {
        [NameInMap("AuditContentItemList")]
        [Validation(Required=false)]
        public List<DescribeAuditContentItemResponseBodyAuditContentItemList> AuditContentItemList { get; set; }
        public class DescribeAuditContentItemResponseBodyAuditContentItemList : TeaModel {
            [NameInMap("Audit")]
            [Validation(Required=false)]
            public int? Audit { get; set; }

            [NameInMap("AuditIllegalReasons")]
            [Validation(Required=false)]
            public List<string> AuditIllegalReasons { get; set; }

            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ParentTaskId")]
            [Validation(Required=false)]
            public string ParentTaskId { get; set; }

            [NameInMap("Sn")]
            [Validation(Required=false)]
            public int? Sn { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
