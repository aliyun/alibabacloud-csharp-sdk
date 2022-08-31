// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
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
                public int? AccountMaxQuantity { get; set; }
                public string AdvancedFeatures { get; set; }
                public string AutoUpgradeMinorVersion { get; set; }
                public string AvailabilityValue { get; set; }
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeBabelfishConfig BabelfishConfig { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeBabelfishConfig : TeaModel {
                    [NameInMap("BabelfishEnabled")]
                    [Validation(Required=false)]
                    public string BabelfishEnabled { get; set; }

                    [NameInMap("MigrationMode")]
                    [Validation(Required=false)]
                    public string MigrationMode { get; set; }

                }
                public string Category { get; set; }
                public string Collation { get; set; }
                public string ConnectionMode { get; set; }
                public string ConnectionString { get; set; }
                public string ConsoleVersion { get; set; }
                public string CreationTime { get; set; }
                public string CurrentKernelVersion { get; set; }
                public string DBInstanceCPU { get; set; }
                public string DBInstanceClass { get; set; }
                public string DBInstanceClassType { get; set; }
                public string DBInstanceDescription { get; set; }
                public string DBInstanceId { get; set; }
                public long? DBInstanceMemory { get; set; }
                public string DBInstanceNetType { get; set; }
                public string DBInstanceStatus { get; set; }
                public int? DBInstanceStorage { get; set; }
                public string DBInstanceStorageType { get; set; }
                public string DBInstanceType { get; set; }
                public int? DBMaxQuantity { get; set; }
                public string DedicatedHostGroupId { get; set; }
                public bool? DeletionProtection { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string ExpireTime { get; set; }
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
                public string GeneralGroupName { get; set; }
                public string GuardDBInstanceId { get; set; }
                public string IPType { get; set; }
                public string IncrementSourceDBInstanceId { get; set; }
                public string InstanceNetworkType { get; set; }
                public string LatestKernelVersion { get; set; }
                public string LockMode { get; set; }
                public string LockReason { get; set; }
                public string MaintainTime { get; set; }
                public string MasterInstanceId { get; set; }
                public string MasterZone { get; set; }
                public int? MaxConnections { get; set; }
                public int? MaxIOMBPS { get; set; }
                public int? MaxIOPS { get; set; }
                public string PayType { get; set; }
                public string Port { get; set; }
                public int? ProxyType { get; set; }
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
                public string ReadonlyInstanceSQLDelayedTime { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public string SecurityIPList { get; set; }
                public string SecurityIPMode { get; set; }
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeServerlessConfig ServerlessConfig { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeServerlessConfig : TeaModel {
                    [NameInMap("AutoPause")]
                    [Validation(Required=false)]
                    public bool? AutoPause { get; set; }

                    [NameInMap("ScaleMax")]
                    [Validation(Required=false)]
                    public double? ScaleMax { get; set; }

                    [NameInMap("ScaleMin")]
                    [Validation(Required=false)]
                    public double? ScaleMin { get; set; }

                    [NameInMap("SwitchForce")]
                    [Validation(Required=false)]
                    public bool? SwitchForce { get; set; }

                }
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
                public string SuperPermissionMode { get; set; }
                public string TempDBInstanceId { get; set; }
                public string TimeZone { get; set; }
                public string Tips { get; set; }
                public int? TipsLevel { get; set; }
                public string VSwitchId { get; set; }
                public string VpcCloudInstanceId { get; set; }
                public string VpcId { get; set; }
                public string ZoneId { get; set; }
                public string KindCode { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
