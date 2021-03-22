// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceAttributeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public DescribeDBInstanceAttributeResponseItems Items { get; set; }
        public class DescribeDBInstanceAttributeResponseItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=true)]
            public List<DescribeDBInstanceAttributeResponseItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstanceAttributeResponseItemsDBInstanceAttribute : TeaModel {
                public string DBInstanceId { get; set; }
                public string PayType { get; set; }
                public string DBInstanceClassType { get; set; }
                public string RegionId { get; set; }
                public string ConnectionString { get; set; }
                public string Port { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string DBInstanceClass { get; set; }
                public int? DBInstanceCpuCores { get; set; }
                public long? DBInstanceMemory { get; set; }
                public long? DBInstanceStorage { get; set; }
                public long? DBInstanceDiskMBPS { get; set; }
                public string HostType { get; set; }
                public string DBInstanceGroupCount { get; set; }
                public string DBInstanceNetType { get; set; }
                public string DBInstanceStatus { get; set; }
                public string DBInstanceDescription { get; set; }
                public string LockMode { get; set; }
                public string LockReason { get; set; }
                public string ReadDelayTime { get; set; }
                public string CreationTime { get; set; }
                public string ExpireTime { get; set; }
                public string MaintainStartTime { get; set; }
                public string MaintainEndTime { get; set; }
                public string AvailabilityValue { get; set; }
                public int? MaxConnections { get; set; }
                public string SecurityIPList { get; set; }
                public string ZoneId { get; set; }
                public string InstanceNetworkType { get; set; }
                public string VpcId { get; set; }
                public string ConnectionMode { get; set; }
                public string StorageType { get; set; }
                public int? CpuCoresPerNode { get; set; }
                public int? SegmentCounts { get; set; }
                public int? StoragePerNode { get; set; }
                public int? MemoryPerNode { get; set; }
                public string StorageUnit { get; set; }
                public string MemoryUnit { get; set; }
                public DescribeDBInstanceAttributeResponseItemsDBInstanceAttributeTags Tags { get; set; }
                public class DescribeDBInstanceAttributeResponseItemsDBInstanceAttributeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=true)]
                    public List<DescribeDBInstanceAttributeResponseItemsDBInstanceAttributeTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceAttributeResponseItemsDBInstanceAttributeTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=true)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=true)]
                        public string Value { get; set; }

                    }

                }
            }
        };

    }

}
