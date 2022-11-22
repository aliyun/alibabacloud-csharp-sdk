// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossRegionBackupDBInstanceResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionBackupDBInstanceResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionBackupDBInstanceResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionBackupDBInstanceResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionBackupDBInstanceResponseBodyItemsItem : TeaModel {
                [NameInMap("BackupEnabled")]
                [Validation(Required=false)]
                public string BackupEnabled { get; set; }

                [NameInMap("BackupEnabledTime")]
                [Validation(Required=false)]
                public string BackupEnabledTime { get; set; }

                [NameInMap("CrossBackupRegion")]
                [Validation(Required=false)]
                public string CrossBackupRegion { get; set; }

                [NameInMap("CrossBackupType")]
                [Validation(Required=false)]
                public string CrossBackupType { get; set; }

                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("LogBackupEnabled")]
                [Validation(Required=false)]
                public string LogBackupEnabled { get; set; }

                [NameInMap("LogBackupEnabledTime")]
                [Validation(Required=false)]
                public string LogBackupEnabledTime { get; set; }

                [NameInMap("RetentType")]
                [Validation(Required=false)]
                public int? RetentType { get; set; }

                [NameInMap("Retention")]
                [Validation(Required=false)]
                public int? Retention { get; set; }

            }

        }

        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

    }

}
