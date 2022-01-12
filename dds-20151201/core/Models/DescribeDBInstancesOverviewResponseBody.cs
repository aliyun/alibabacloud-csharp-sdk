// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesOverviewResponseBody : TeaModel {
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesOverviewResponseBodyDBInstances> DBInstances { get; set; }
        public class DescribeDBInstancesOverviewResponseBodyDBInstances : TeaModel {
            [NameInMap("CapacityUnit")]
            [Validation(Required=false)]
            public string CapacityUnit { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DBInstanceClass")]
            [Validation(Required=false)]
            public string DBInstanceClass { get; set; }

            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            [NameInMap("DBInstanceStatus")]
            [Validation(Required=false)]
            public string DBInstanceStatus { get; set; }

            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public int? DBInstanceStorage { get; set; }

            [NameInMap("DBInstanceType")]
            [Validation(Required=false)]
            public string DBInstanceType { get; set; }

            [NameInMap("DestroyTime")]
            [Validation(Required=false)]
            public string DestroyTime { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("KindCode")]
            [Validation(Required=false)]
            public string KindCode { get; set; }

            [NameInMap("LastDowngradeTime")]
            [Validation(Required=false)]
            public string LastDowngradeTime { get; set; }

            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            [NameInMap("MongosList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesMongosList> MongosList { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesMongosList : TeaModel {
                [NameInMap("NodeClass")]
                [Validation(Required=false)]
                public string NodeClass { get; set; }

                [NameInMap("NodeDescription")]
                [Validation(Required=false)]
                public string NodeDescription { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ReplicationFactor")]
            [Validation(Required=false)]
            public string ReplicationFactor { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ShardList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesShardList> ShardList { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesShardList : TeaModel {
                [NameInMap("NodeClass")]
                [Validation(Required=false)]
                public string NodeClass { get; set; }

                [NameInMap("NodeDescription")]
                [Validation(Required=false)]
                public string NodeDescription { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeStorage")]
                [Validation(Required=false)]
                public int? NodeStorage { get; set; }

                [NameInMap("ReadonlyReplicas")]
                [Validation(Required=false)]
                public int? ReadonlyReplicas { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesTags> Tags { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("VpcAuthMode")]
            [Validation(Required=false)]
            public string VpcAuthMode { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
