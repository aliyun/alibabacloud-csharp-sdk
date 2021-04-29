// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesForCloneResponseBody : TeaModel {
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesForCloneResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesForCloneResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesForCloneResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesForCloneResponseBodyItemsDBInstance : TeaModel {
                public string VpcId { get; set; }
                public string ReplicateId { get; set; }
                public string TempDBInstanceId { get; set; }
                public string DBInstanceStorageType { get; set; }
                public string CreateTime { get; set; }
                public string PayType { get; set; }
                public bool? MutriORsignle { get; set; }
                public string ConnectionMode { get; set; }
                public string LockMode { get; set; }
                public string EngineVersion { get; set; }
                public string VpcCloudInstanceId { get; set; }
                public int? InsId { get; set; }
                public string InstanceNetworkType { get; set; }
                public string MasterInstanceId { get; set; }
                public string DBInstanceDescription { get; set; }
                public string DBInstanceNetType { get; set; }
                public string ExpireTime { get; set; }
                public string DBInstanceType { get; set; }
                public string DestroyTime { get; set; }
                public string LockReason { get; set; }
                public string DBInstanceStatus { get; set; }
                public DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId> ReadOnlyDBInstanceId { get; set; }
                    public class DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId : TeaModel {
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                }
                public string GuardDBInstanceId { get; set; }
                public string RegionId { get; set; }
                public string VSwitchId { get; set; }
                public string ResourceGroupId { get; set; }
                public string ZoneId { get; set; }
                public string DBInstanceId { get; set; }
                public string Category { get; set; }
                public string Engine { get; set; }
                public string DBInstanceClass { get; set; }
            }
        };

    }

}
