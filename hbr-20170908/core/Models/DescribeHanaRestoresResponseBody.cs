// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaRestoresResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HanaRestore")]
        [Validation(Required=false)]
        public DescribeHanaRestoresResponseBodyHanaRestore HanaRestore { get; set; }
        public class DescribeHanaRestoresResponseBodyHanaRestore : TeaModel {
            [NameInMap("HanaRestores")]
            [Validation(Required=false)]
            public List<DescribeHanaRestoresResponseBodyHanaRestoreHanaRestores> HanaRestores { get; set; }
            public class DescribeHanaRestoresResponseBodyHanaRestoreHanaRestores : TeaModel {
                public long? BackupID { get; set; }
                public string BackupPrefix { get; set; }
                public bool? CheckAccess { get; set; }
                public bool? ClearLog { get; set; }
                public string ClusterId { get; set; }
                public int? CurrentPhase { get; set; }
                public long? CurrentProgress { get; set; }
                public string DatabaseName { get; set; }
                public long? DatabaseRestoreId { get; set; }
                public long? EndTime { get; set; }
                public long? LogPosition { get; set; }
                public int? MaxPhase { get; set; }
                public long? MaxProgress { get; set; }
                public string Message { get; set; }
                public string Mode { get; set; }
                public string Phase { get; set; }
                public long? ReachedTime { get; set; }
                public long? RecoveryPointInTime { get; set; }
                public string RestoreId { get; set; }
                public string Source { get; set; }
                public string SourceClusterId { get; set; }
                public long? StartTime { get; set; }
                public string State { get; set; }
                public string Status { get; set; }
                public bool? SystemCopy { get; set; }
                public bool? UseCatalog { get; set; }
                public bool? UseDelta { get; set; }
                public string VaultId { get; set; }
                public int? VolumeId { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
