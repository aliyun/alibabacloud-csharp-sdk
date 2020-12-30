// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeFullBackupListResponseBody : TeaModel {
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeFullBackupListResponseBodyItems Items { get; set; }
        public class DescribeFullBackupListResponseBodyItems : TeaModel {
            [NameInMap("FullBackupFile")]
            [Validation(Required=false)]
            public List<DescribeFullBackupListResponseBodyItemsFullBackupFile> FullBackupFile { get; set; }
            public class DescribeFullBackupListResponseBodyItemsFullBackupFile : TeaModel {
                public long? FinishTime { get; set; }
                public string BackupStatus { get; set; }
                public long? CreateTime { get; set; }
                public string SourceEndpointIpPort { get; set; }
                public string BackupObjects { get; set; }
                public string ErrMessage { get; set; }
                public long? EndTime { get; set; }
                public long? BackupSetExpiredTime { get; set; }
                public long? StartTime { get; set; }
                public string StorageMethod { get; set; }
                public string BackupSetId { get; set; }
                public long? BackupSize { get; set; }
            }
        };

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

    }

}
