// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeIncrementBackupListResponseBody : TeaModel {
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
        public DescribeIncrementBackupListResponseBodyItems Items { get; set; }
        public class DescribeIncrementBackupListResponseBodyItems : TeaModel {
            [NameInMap("IncrementBackupFile")]
            [Validation(Required=false)]
            public List<DescribeIncrementBackupListResponseBodyItemsIncrementBackupFile> IncrementBackupFile { get; set; }
            public class DescribeIncrementBackupListResponseBodyItemsIncrementBackupFile : TeaModel {
                public long? EndTime { get; set; }
                public long? BackupSetExpiredTime { get; set; }
                public long? StartTime { get; set; }
                public string StorageMethod { get; set; }
                public string BackupSetJobId { get; set; }
                public string BackupSetId { get; set; }
                public string BackupStatus { get; set; }
                public string SourceEndpointIpPort { get; set; }
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
