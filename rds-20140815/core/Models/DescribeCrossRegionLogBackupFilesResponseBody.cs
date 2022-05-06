// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossRegionLogBackupFilesResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionLogBackupFilesResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionLogBackupFilesResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionLogBackupFilesResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionLogBackupFilesResponseBodyItemsItem : TeaModel {
                public string CrossBackupRegion { get; set; }
                public string CrossDownloadLink { get; set; }
                public string CrossIntranetDownloadLink { get; set; }
                public int? CrossLogBackupId { get; set; }
                public long? CrossLogBackupSize { get; set; }
                public int? InstanceId { get; set; }
                public string LinkExpiredTime { get; set; }
                public string LogBeginTime { get; set; }
                public string LogEndTime { get; set; }
                public string LogFileName { get; set; }
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
