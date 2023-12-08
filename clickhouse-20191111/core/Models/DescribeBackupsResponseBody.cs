// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeBackupsResponseBodyItems> Items { get; set; }
        public class DescribeBackupsResponseBodyItems : TeaModel {
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public string BackupEndTime { get; set; }

            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            [NameInMap("BackupMethod")]
            [Validation(Required=false)]
            public string BackupMethod { get; set; }

            [NameInMap("BackupSetInfo")]
            [Validation(Required=false)]
            public string BackupSetInfo { get; set; }

            [NameInMap("BackupSize")]
            [Validation(Required=false)]
            public long? BackupSize { get; set; }

            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
