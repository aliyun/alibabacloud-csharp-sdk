// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class ListBackupsResponseBody : TeaModel {
        [NameInMap("Backups")]
        [Validation(Required=false)]
        public List<ListBackupsResponseBodyBackups> Backups { get; set; }
        public class ListBackupsResponseBodyBackups : TeaModel {
            [NameInMap("AutoImageCount")]
            [Validation(Required=false)]
            public long? AutoImageCount { get; set; }

            [NameInMap("BackupHourInDay")]
            [Validation(Required=false)]
            public string BackupHourInDay { get; set; }

            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            [NameInMap("BackupPeriod")]
            [Validation(Required=false)]
            public long? BackupPeriod { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MaxImageCount")]
            [Validation(Required=false)]
            public string MaxImageCount { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NextImageCreateTime")]
            [Validation(Required=false)]
            public long? NextImageCreateTime { get; set; }

            [NameInMap("OwnerInstanceId")]
            [Validation(Required=false)]
            public string OwnerInstanceId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("SpInstanceId")]
            [Validation(Required=false)]
            public string SpInstanceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
