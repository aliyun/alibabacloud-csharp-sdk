// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataBackupsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataBackupsResponseBodyItems> Items { get; set; }
        public class DescribeDataBackupsResponseBodyItems : TeaModel {
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public string BackupEndTime { get; set; }

            [NameInMap("BackupEndTimeLocal")]
            [Validation(Required=false)]
            public string BackupEndTimeLocal { get; set; }

            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            [NameInMap("BackupSetId")]
            [Validation(Required=false)]
            public string BackupSetId { get; set; }

            [NameInMap("BackupSize")]
            [Validation(Required=false)]
            public long? BackupSize { get; set; }

            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            [NameInMap("BackupStartTimeLocal")]
            [Validation(Required=false)]
            public string BackupStartTimeLocal { get; set; }

            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            [NameInMap("BaksetName")]
            [Validation(Required=false)]
            public string BaksetName { get; set; }

            [NameInMap("ConsistentTime")]
            [Validation(Required=false)]
            public long? ConsistentTime { get; set; }

            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

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
