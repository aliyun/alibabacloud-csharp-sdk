// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class DbfsRecordResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DbfsRecordResponseBodyRecords> Records { get; set; }
        public class DbfsRecordResponseBodyRecords : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("BatchStrategyNo")]
            [Validation(Required=false)]
            public string BatchStrategyNo { get; set; }

            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("DbfsId")]
            [Validation(Required=false)]
            public string DbfsId { get; set; }

            [NameInMap("EcsId")]
            [Validation(Required=false)]
            public string EcsId { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            [NameInMap("TargetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

            [NameInMap("UpgradeStartTime")]
            [Validation(Required=false)]
            public long? UpgradeStartTime { get; set; }

            [NameInMap("UpgradeEndTime")]
            [Validation(Required=false)]
            public long? UpgradeEndTime { get; set; }

            [NameInMap("TaskExecutionCounts")]
            [Validation(Required=false)]
            public int? TaskExecutionCounts { get; set; }

            [NameInMap("TaskErrorReason")]
            [Validation(Required=false)]
            public string TaskErrorReason { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("IsDel")]
            [Validation(Required=false)]
            public string IsDel { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
