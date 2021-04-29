// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute : TeaModel {
                public string CreationTime { get; set; }
                public string VpcId { get; set; }
                public string IncrementSourceDBInstanceId { get; set; }
                public string MaintainTime { get; set; }
                public string PayType { get; set; }
                public string AvailabilityValue { get; set; }
                public string EngineVersion { get; set; }
                public string DedicatedHostGroupId { get; set; }
                public string ConnectionString { get; set; }
                public string SuperPermissionMode { get; set; }
                public string InstanceNetworkType { get; set; }
                public string MasterInstanceId { get; set; }
                public string AutoUpgradeMinorVersion { get; set; }
                public string ExpireTime { get; set; }
                public int? AccountMaxQuantity { get; set; }
                public string MasterZone { get; set; }
                public string GuardDBInstanceId { get; set; }
                public int? DBInstanceStorage { get; set; }
                public string TimeZone { get; set; }
                public string ZoneId { get; set; }
                public string DBInstanceId { get; set; }
                public int? MaxConnections { get; set; }
                public string TempDBInstanceId { get; set; }
                public long? DBInstanceMemory { get; set; }
                public string DBInstanceStorageType { get; set; }
                public string AdvancedFeatures { get; set; }
                public string Port { get; set; }
                public string ConnectionMode { get; set; }
                public string ConsoleVersion { get; set; }
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtra Extra { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtra : TeaModel {
                    [NameInMap("DBInstanceIds")]
                    [Validation(Required=false)]
                    public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtraDBInstanceIds DBInstanceIds { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtraDBInstanceIds : TeaModel {
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public List<string> DBInstanceId { get; set; }
                    };

                }
                public string LockMode { get; set; }
                public string VpcCloudInstanceId { get; set; }
                public string Collation { get; set; }
                public int? MaxIOPS { get; set; }
                public string SecurityIPMode { get; set; }
                public string DBInstanceClassType { get; set; }
                public int? ProxyType { get; set; }
                public string CurrentKernelVersion { get; set; }
                public string DBInstanceDescription { get; set; }
                public string DBInstanceCPU { get; set; }
                public string DBInstanceNetType { get; set; }
                public string DBInstanceType { get; set; }
                public string LockReason { get; set; }
                public string DBInstanceStatus { get; set; }
                public int? DBMaxQuantity { get; set; }
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIdsReadOnlyDBInstanceId> ReadOnlyDBInstanceId { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIdsReadOnlyDBInstanceId : TeaModel {
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                }
                public string RegionId { get; set; }
                public string ReadonlyInstanceSQLDelayedTime { get; set; }
                public string VSwitchId { get; set; }
                public string ResourceGroupId { get; set; }
                public string Category { get; set; }
                public string DBInstanceClass { get; set; }
                public string Engine { get; set; }
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZones SlaveZones { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZones : TeaModel {
                    [NameInMap("SlaveZone")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZonesSlaveZone> SlaveZone { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZonesSlaveZone : TeaModel {
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }
            }
        };

    }

}
