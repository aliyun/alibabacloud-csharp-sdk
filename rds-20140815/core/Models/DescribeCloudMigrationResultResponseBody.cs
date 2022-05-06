// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCloudMigrationResultResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCloudMigrationResultResponseBodyItems> Items { get; set; }
        public class DescribeCloudMigrationResultResponseBodyItems : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("MigrateStage")]
            [Validation(Required=false)]
            public string MigrateStage { get; set; }

            [NameInMap("ReplicationInfo")]
            [Validation(Required=false)]
            public string ReplicationInfo { get; set; }

            [NameInMap("ReplicationState")]
            [Validation(Required=false)]
            public string ReplicationState { get; set; }

            [NameInMap("SourceAccount")]
            [Validation(Required=false)]
            public string SourceAccount { get; set; }

            [NameInMap("SourceCategory")]
            [Validation(Required=false)]
            public string SourceCategory { get; set; }

            [NameInMap("SourceIpAddress")]
            [Validation(Required=false)]
            public string SourceIpAddress { get; set; }

            [NameInMap("SourcePassword")]
            [Validation(Required=false)]
            public string SourcePassword { get; set; }

            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public long? SourcePort { get; set; }

            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            [NameInMap("TargetEip")]
            [Validation(Required=false)]
            public string TargetEip { get; set; }

            [NameInMap("TargetInstanceName")]
            [Validation(Required=false)]
            public string TargetInstanceName { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
