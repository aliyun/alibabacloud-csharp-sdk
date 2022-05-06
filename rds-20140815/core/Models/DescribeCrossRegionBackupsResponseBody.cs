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
                public string BackupEndTime { get; set; }
                public string BackupMethod { get; set; }
                public int? BackupSetScale { get; set; }
                public int? BackupSetStatus { get; set; }
                public string BackupStartTime { get; set; }
                public string BackupType { get; set; }
                public string Category { get; set; }
                public string ConsistentTime { get; set; }
                public string CrossBackupDownloadLink { get; set; }
                public int? CrossBackupId { get; set; }
                public string CrossBackupRegion { get; set; }
                public string CrossBackupSetFile { get; set; }
                public string CrossBackupSetLocation { get; set; }
                public long? CrossBackupSetSize { get; set; }
                public string DBInstanceStorageType { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public int? InstanceId { get; set; }
                public DescribeCrossRegionBackupsResponseBodyItemsItemRestoreRegions RestoreRegions { get; set; }
                public class DescribeCrossRegionBackupsResponseBodyItemsItemRestoreRegions : TeaModel {
                    [NameInMap("RestoreRegion")]
                    [Validation(Required=false)]
                    public List<string> RestoreRegion { get; set; }

                }
            }
        };

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
