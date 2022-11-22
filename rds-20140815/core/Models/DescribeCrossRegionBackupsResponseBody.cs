// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossRegionBackupsResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionBackupsResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionBackupsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionBackupsResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionBackupsResponseBodyItemsItem : TeaModel {
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                [NameInMap("BackupSetScale")]
                [Validation(Required=false)]
                public int? BackupSetScale { get; set; }

                [NameInMap("BackupSetStatus")]
                [Validation(Required=false)]
                public int? BackupSetStatus { get; set; }

                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public string ConsistentTime { get; set; }

                [NameInMap("CrossBackupDownloadLink")]
                [Validation(Required=false)]
                public string CrossBackupDownloadLink { get; set; }

                [NameInMap("CrossBackupId")]
                [Validation(Required=false)]
                public int? CrossBackupId { get; set; }

                [NameInMap("CrossBackupRegion")]
                [Validation(Required=false)]
                public string CrossBackupRegion { get; set; }

                [NameInMap("CrossBackupSetFile")]
                [Validation(Required=false)]
                public string CrossBackupSetFile { get; set; }

                [NameInMap("CrossBackupSetLocation")]
                [Validation(Required=false)]
                public string CrossBackupSetLocation { get; set; }

                [NameInMap("CrossBackupSetSize")]
                [Validation(Required=false)]
                public long? CrossBackupSetSize { get; set; }

                [NameInMap("DBInstanceStorageType")]
                [Validation(Required=false)]
                public string DBInstanceStorageType { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

                [NameInMap("RestoreRegions")]
                [Validation(Required=false)]
                public DescribeCrossRegionBackupsResponseBodyItemsItemRestoreRegions RestoreRegions { get; set; }
                public class DescribeCrossRegionBackupsResponseBodyItemsItemRestoreRegions : TeaModel {
                    [NameInMap("RestoreRegion")]
                    [Validation(Required=false)]
                    public List<string> RestoreRegion { get; set; }

                }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
