// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeLogBackupsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeLogBackupsResponseBodyItems> Items { get; set; }
        public class DescribeLogBackupsResponseBodyItems : TeaModel {
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            [NameInMap("LogFileName")]
            [Validation(Required=false)]
            public string LogFileName { get; set; }

            [NameInMap("LogFileSize")]
            [Validation(Required=false)]
            public long? LogFileSize { get; set; }

            [NameInMap("LogTime")]
            [Validation(Required=false)]
            public string LogTime { get; set; }

            [NameInMap("SegmentName")]
            [Validation(Required=false)]
            public string SegmentName { get; set; }

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

        [NameInMap("TotalLogSize")]
        [Validation(Required=false)]
        public long? TotalLogSize { get; set; }

    }

}
