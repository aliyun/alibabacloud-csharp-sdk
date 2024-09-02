// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeRestorableTenantsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tenants")]
        [Validation(Required=false)]
        public List<DescribeRestorableTenantsResponseBodyTenants> Tenants { get; set; }
        public class DescribeRestorableTenantsResponseBodyTenants : TeaModel {
            [NameInMap("BackupBucketName")]
            [Validation(Required=false)]
            public string BackupBucketName { get; set; }

            [NameInMap("BackupSets")]
            [Validation(Required=false)]
            public List<DescribeRestorableTenantsResponseBodyTenantsBackupSets> BackupSets { get; set; }
            public class DescribeRestorableTenantsResponseBodyTenantsBackupSets : TeaModel {
                [NameInMap("BackupSetId")]
                [Validation(Required=false)]
                public string BackupSetId { get; set; }

                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

                [NameInMap("SetId")]
                [Validation(Required=false)]
                public string SetId { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("CpuNum")]
            [Validation(Required=false)]
            public long? CpuNum { get; set; }

            [NameInMap("MemoryNum")]
            [Validation(Required=false)]
            public long? MemoryNum { get; set; }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("ObRpmVersion")]
            [Validation(Required=false)]
            public string ObRpmVersion { get; set; }

            [NameInMap("ObTenantId")]
            [Validation(Required=false)]
            public string ObTenantId { get; set; }

            [NameInMap("ObVersion")]
            [Validation(Required=false)]
            public string ObVersion { get; set; }

            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            [NameInMap("TenantAlias")]
            [Validation(Required=false)]
            public string TenantAlias { get; set; }

            [NameInMap("TenantDataBackupRemainDays")]
            [Validation(Required=false)]
            public int? TenantDataBackupRemainDays { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            [NameInMap("TimeIntervalList")]
            [Validation(Required=false)]
            public List<DescribeRestorableTenantsResponseBodyTenantsTimeIntervalList> TimeIntervalList { get; set; }
            public class DescribeRestorableTenantsResponseBodyTenantsTimeIntervalList : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("FromArchive")]
                [Validation(Required=false)]
                public bool? FromArchive { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public long? UnitNum { get; set; }

            [NameInMap("UsedDisk")]
            [Validation(Required=false)]
            public long? UsedDisk { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
