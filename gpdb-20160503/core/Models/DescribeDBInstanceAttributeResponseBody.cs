// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute : TeaModel {
                public string AvailabilityValue { get; set; }
                public string ConnectionMode { get; set; }
                public string ConnectionString { get; set; }
                public string CoreVersion { get; set; }
                public int? CpuCores { get; set; }
                public int? CpuCoresPerNode { get; set; }
                public string CreationTime { get; set; }
                public string DBInstanceCategory { get; set; }
                public string DBInstanceClass { get; set; }
                public string DBInstanceClassType { get; set; }
                public int? DBInstanceCpuCores { get; set; }
                public string DBInstanceDescription { get; set; }
                public long? DBInstanceDiskMBPS { get; set; }
                public string DBInstanceGroupCount { get; set; }
                public string DBInstanceId { get; set; }
                public long? DBInstanceMemory { get; set; }
                public string DBInstanceMode { get; set; }
                public string DBInstanceNetType { get; set; }
                public string DBInstanceStatus { get; set; }
                public long? DBInstanceStorage { get; set; }
                public string EncryptionKey { get; set; }
                public string EncryptionType { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string ExpireTime { get; set; }
                public string HostType { get; set; }
                public string InstanceNetworkType { get; set; }
                public string LockMode { get; set; }
                public string LockReason { get; set; }
                public string MaintainEndTime { get; set; }
                public string MaintainStartTime { get; set; }
                public int? MasterNodeNum { get; set; }
                public int? MaxConnections { get; set; }
                public int? MemoryPerNode { get; set; }
                public long? MemorySize { get; set; }
                public string MemoryUnit { get; set; }
                public string MinorVersion { get; set; }
                public string PayType { get; set; }
                public string Port { get; set; }
                public string ReadDelayTime { get; set; }
                public string RegionId { get; set; }
                public string RunningTime { get; set; }
                public string SecurityIPList { get; set; }
                public int? SegNodeNum { get; set; }
                public int? SegmentCounts { get; set; }
                public string StartTime { get; set; }
                public int? StoragePerNode { get; set; }
                public long? StorageSize { get; set; }
                public string StorageType { get; set; }
                public string StorageUnit { get; set; }
                public bool? SupportRestore { get; set; }
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTags Tags { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string VSwitchId { get; set; }
                public string VpcId { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
