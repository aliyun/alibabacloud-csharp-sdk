// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesAsCsvResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesAsCsvResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesAsCsvResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesAsCsvResponseBodyItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstancesAsCsvResponseBodyItemsDBInstanceAttribute : TeaModel {
                public int? AccountMaxQuantity { get; set; }
                public string AccountType { get; set; }
                public string AvailabilityValue { get; set; }
                public string Category { get; set; }
                public string ConnectionMode { get; set; }
                public string ConnectionString { get; set; }
                public string CreationTime { get; set; }
                public string DBInstanceCPU { get; set; }
                public string DBInstanceClass { get; set; }
                public string DBInstanceClassType { get; set; }
                public string DBInstanceDescription { get; set; }
                public string DBInstanceId { get; set; }
                public long? DBInstanceMemory { get; set; }
                public string DBInstanceNetType { get; set; }
                public string DBInstanceStatus { get; set; }
                public int? DBInstanceStorage { get; set; }
                public string DBInstanceType { get; set; }
                public int? DBMaxQuantity { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string ExpireTime { get; set; }
                public string GuardDBInstanceId { get; set; }
                public string IncrementSourceDBInstanceId { get; set; }
                public string InstanceNetworkType { get; set; }
                public string LockMode { get; set; }
                public string LockReason { get; set; }
                public string MaintainTime { get; set; }
                public string MasterInstanceId { get; set; }
                public int? MaxConnections { get; set; }
                public int? MaxIOPS { get; set; }
                public string PayType { get; set; }
                public string Port { get; set; }
                public string ReadDelayTime { get; set; }
                public string RegionId { get; set; }
                public string SecurityIPList { get; set; }
                public string SupportUpgradeAccountType { get; set; }
                public string Tags { get; set; }
                public string TempDBInstanceId { get; set; }
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
