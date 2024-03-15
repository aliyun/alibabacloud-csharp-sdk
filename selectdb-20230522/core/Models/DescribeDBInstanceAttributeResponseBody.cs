// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        [NameInMap("CanUpgradeVersions")]
        [Validation(Required=false)]
        public List<string> CanUpgradeVersions { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DBClusterList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyDBClusterList> DBClusterList { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBClusterList : TeaModel {
            [NameInMap("CacheStorageSizeGB")]
            [Validation(Required=false)]
            public string CacheStorageSizeGB { get; set; }

            [NameInMap("CacheStorageType")]
            [Validation(Required=false)]
            public string CacheStorageType { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public long? CpuCores { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("DbClusterClass")]
            [Validation(Required=false)]
            public string DbClusterClass { get; set; }

            [NameInMap("DbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            [NameInMap("DbClusterName")]
            [Validation(Required=false)]
            public string DbClusterName { get; set; }

            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("EngineMinorVersion")]
        [Validation(Required=false)]
        public string EngineMinorVersion { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public long? LockMode { get; set; }

        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        [NameInMap("MaintainEndtime")]
        [Validation(Required=false)]
        public string MaintainEndtime { get; set; }

        [NameInMap("MaintainStarttime")]
        [Validation(Required=false)]
        public string MaintainStarttime { get; set; }

        [NameInMap("ObjectStoreSize")]
        [Validation(Required=false)]
        public long? ObjectStoreSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceCpu")]
        [Validation(Required=false)]
        public long? ResourceCpu { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

    }

}
