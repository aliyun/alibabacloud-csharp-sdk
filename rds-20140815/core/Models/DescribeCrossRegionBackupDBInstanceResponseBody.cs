// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossRegionBackupDBInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionBackupDBInstanceResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionBackupDBInstanceResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionBackupDBInstanceResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionBackupDBInstanceResponseBodyItemsItem : TeaModel {
                public string DBInstanceId { get; set; }
                public string DBInstanceDescription { get; set; }
                public string DBInstanceStatus { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string CrossBackupRegion { get; set; }
                public string CrossBackupType { get; set; }
                public string BackupEnabled { get; set; }
                public string LogBackupEnabled { get; set; }
                public string LogBackupEnabledTime { get; set; }
                public string BackupEnabledTime { get; set; }
                public int? RetentType { get; set; }
                public int? Retention { get; set; }
                public string LockMode { get; set; }
            }
        };

    }

}
