// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesResponseBodyItems> Items { get; set; }
        public class DescribeDBInstancesResponseBodyItems : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DBClusterList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsDBClusterList> DBClusterList { get; set; }
            public class DescribeDBInstancesResponseBodyItemsDBClusterList : TeaModel {
                [NameInMap("CacheStorageSizeGiB")]
                [Validation(Required=false)]
                public long? CacheStorageSizeGiB { get; set; }

                [NameInMap("CacheStorageType")]
                [Validation(Required=false)]
                public string CacheStorageType { get; set; }

                [NameInMap("CpuCores")]
                [Validation(Required=false)]
                public long? CpuCores { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DbClusterClass")]
                [Validation(Required=false)]
                public string DbClusterClass { get; set; }

                [NameInMap("DbClusterId")]
                [Validation(Required=false)]
                public string DbClusterId { get; set; }

                [NameInMap("DbClusterName")]
                [Validation(Required=false)]
                public string DbClusterName { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public long? Memory { get; set; }

                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("objectStoreSizeGiB")]
                [Validation(Required=false)]
                public long? ObjectStoreSizeGiB { get; set; }

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

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            [NameInMap("InstanceUsedType")]
            [Validation(Required=false)]
            public string InstanceUsedType { get; set; }

            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public long? LockMode { get; set; }

            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            [NameInMap("MaintainEndTimeStr")]
            [Validation(Required=false)]
            public string MaintainEndTimeStr { get; set; }

            [NameInMap("MaintainEndtime")]
            [Validation(Required=false)]
            public string MaintainEndtime { get; set; }

            [NameInMap("MaintainStartTimeStr")]
            [Validation(Required=false)]
            public string MaintainStartTimeStr { get; set; }

            [NameInMap("MaintainStarttime")]
            [Validation(Required=false)]
            public string MaintainStarttime { get; set; }

            [NameInMap("ObjectStoreSize")]
            [Validation(Required=false)]
            public long? ObjectStoreSize { get; set; }

            [NameInMap("ParentInstance")]
            [Validation(Required=false)]
            public string ParentInstance { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceCpu")]
            [Validation(Required=false)]
            public long? ResourceCpu { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourceMemory")]
            [Validation(Required=false)]
            public long? ResourceMemory { get; set; }

            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public long? ScaleMax { get; set; }

            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public long? ScaleMin { get; set; }

            [NameInMap("ScaleReplica")]
            [Validation(Required=false)]
            public long? ScaleReplica { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public long? StorageSize { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsTags> Tags { get; set; }
            public class DescribeDBInstancesResponseBodyItemsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("TenantClusterId")]
            [Validation(Required=false)]
            public string TenantClusterId { get; set; }

            [NameInMap("TenantToken")]
            [Validation(Required=false)]
            public string TenantToken { get; set; }

            [NameInMap("TenantUserId")]
            [Validation(Required=false)]
            public string TenantUserId { get; set; }

            /// <summary>
            /// VPC ID。
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("connectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
