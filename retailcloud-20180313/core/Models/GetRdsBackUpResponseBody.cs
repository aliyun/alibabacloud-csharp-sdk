// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class GetRdsBackUpResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRdsBackUpResponseBodyResult Result { get; set; }
        public class GetRdsBackUpResponseBodyResult : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetRdsBackUpResponseBodyResultItems> Items { get; set; }
            public class GetRdsBackUpResponseBodyResultItems : TeaModel {
                public string BackupDBNames { get; set; }
                public string BackupEndTime { get; set; }
                public string BackupExtractionStatus { get; set; }
                public string BackupId { get; set; }
                public string BackupLocation { get; set; }
                public string BackupMethod { get; set; }
                public string BackupMode { get; set; }
                public string BackupScale { get; set; }
                public long? BackupSize { get; set; }
                public string BackupStartTime { get; set; }
                public string BackupStatus { get; set; }
                public string BackupType { get; set; }
                public string DBInstanceId { get; set; }
                public string HostInstanceID { get; set; }
                public string MetaStatus { get; set; }
                public string StoreStatus { get; set; }
                public long? TotalBackupSize { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }
            [NameInMap("PageRecordCount")]
            [Validation(Required=false)]
            public string PageRecordCount { get; set; }
            [NameInMap("TotalBackupSize")]
            [Validation(Required=false)]
            public long? TotalBackupSize { get; set; }
            [NameInMap("TotalRecordCount")]
            [Validation(Required=false)]
            public string TotalRecordCount { get; set; }
        };

    }

}
