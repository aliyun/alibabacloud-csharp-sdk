// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseBodyItemsDBInstance : TeaModel {
                public string Category { get; set; }
                public string ConnectionMode { get; set; }
                public string ConnectionString { get; set; }
                public string CreateTime { get; set; }
                public string DBInstanceClass { get; set; }
                public string DBInstanceDescription { get; set; }
                public string DBInstanceId { get; set; }
                public string DBInstanceNetType { get; set; }
                public string DBInstanceStatus { get; set; }
                public string DBInstanceStorageType { get; set; }
                public string DBInstanceType { get; set; }
                public string DedicatedHostGroupId { get; set; }
                public string DedicatedHostGroupName { get; set; }
                public string DedicatedHostIdForLog { get; set; }
                public string DedicatedHostIdForMaster { get; set; }
                public string DedicatedHostIdForSlave { get; set; }
                public string DedicatedHostNameForLog { get; set; }
                public string DedicatedHostNameForMaster { get; set; }
                public string DedicatedHostNameForSlave { get; set; }
                public string DedicatedHostZoneIdForLog { get; set; }
                public string DedicatedHostZoneIdForMaster { get; set; }
                public string DedicatedHostZoneIdForSlave { get; set; }
                public bool? DeletionProtection { get; set; }
                public string DestroyTime { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string ExpireTime { get; set; }
                public string GeneralGroupName { get; set; }
                public string GuardDBInstanceId { get; set; }
                public string InstanceNetworkType { get; set; }
                public string LockMode { get; set; }
                public string LockReason { get; set; }
                public string MasterInstanceId { get; set; }
                public bool? MutriORsignle { get; set; }
                public string PayType { get; set; }
                public DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId> ReadOnlyDBInstanceId { get; set; }
                    public class DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId : TeaModel {
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public int? SwitchWeight { get; set; }
                public string TempDBInstanceId { get; set; }
                public string Tips { get; set; }
                public int? TipsLevel { get; set; }
                public string VSwitchId { get; set; }
                public string VpcCloudInstanceId { get; set; }
                public string VpcId { get; set; }
                public string VpcName { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
