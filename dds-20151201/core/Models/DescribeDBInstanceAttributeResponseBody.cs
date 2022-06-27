// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyDBInstances DBInstances { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBInstances : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstance> DBInstance { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstance : TeaModel {
                public string CapacityUnit { get; set; }
                public string ChargeType { get; set; }
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverList ConfigserverList { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverList : TeaModel {
                    [NameInMap("ConfigserverAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverListConfigserverAttribute> ConfigserverAttribute { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverListConfigserverAttribute : TeaModel {
                        [NameInMap("ConnectString")]
                        [Validation(Required=false)]
                        public string ConnectString { get; set; }

                        [NameInMap("MaxConnections")]
                        [Validation(Required=false)]
                        public int? MaxConnections { get; set; }

                        [NameInMap("MaxIOPS")]
                        [Validation(Required=false)]
                        public int? MaxIOPS { get; set; }

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

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }
                public string CreationTime { get; set; }
                public string CurrentKernelVersion { get; set; }
                public string DBInstanceClass { get; set; }
                public string DBInstanceDescription { get; set; }
                public string DBInstanceId { get; set; }
                public bool? DBInstanceReleaseProtection { get; set; }
                public string DBInstanceStatus { get; set; }
                public int? DBInstanceStorage { get; set; }
                public string DBInstanceType { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string ExpireTime { get; set; }
                public string HiddenZoneId { get; set; }
                public string KindCode { get; set; }
                public string LastDowngradeTime { get; set; }
                public string LockMode { get; set; }
                public string MaintainEndTime { get; set; }
                public string MaintainStartTime { get; set; }
                public int? MaxConnections { get; set; }
                public int? MaxIOPS { get; set; }
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosList MongosList { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosList : TeaModel {
                    [NameInMap("MongosAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosListMongosAttribute> MongosAttribute { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosListMongosAttribute : TeaModel {
                        [NameInMap("ConnectSting")]
                        [Validation(Required=false)]
                        public string ConnectSting { get; set; }

                        [NameInMap("MaxConnections")]
                        [Validation(Required=false)]
                        public int? MaxConnections { get; set; }

                        [NameInMap("MaxIOPS")]
                        [Validation(Required=false)]
                        public int? MaxIOPS { get; set; }

                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("VPCId")]
                        [Validation(Required=false)]
                        public string VPCId { get; set; }

                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        [NameInMap("VpcCloudInstanceId")]
                        [Validation(Required=false)]
                        public string VpcCloudInstanceId { get; set; }

                    }

                }
                public string NetworkType { get; set; }
                public string ProtocolType { get; set; }
                public string ReadonlyReplicas { get; set; }
                public string RegionId { get; set; }
                public string ReplacateId { get; set; }
                public string ReplicaSetName { get; set; }
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSets ReplicaSets { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSets : TeaModel {
                    [NameInMap("ReplicaSet")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSetsReplicaSet> ReplicaSet { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSetsReplicaSet : TeaModel {
                        [NameInMap("ConnectionDomain")]
                        [Validation(Required=false)]
                        public string ConnectionDomain { get; set; }

                        [NameInMap("ConnectionPort")]
                        [Validation(Required=false)]
                        public string ConnectionPort { get; set; }

                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        [NameInMap("ReplicaSetRole")]
                        [Validation(Required=false)]
                        public string ReplicaSetRole { get; set; }

                        [NameInMap("VPCCloudInstanceId")]
                        [Validation(Required=false)]
                        public string VPCCloudInstanceId { get; set; }

                        [NameInMap("VPCId")]
                        [Validation(Required=false)]
                        public string VPCId { get; set; }

                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                    }

                }
                public string ReplicationFactor { get; set; }
                public string ResourceGroupId { get; set; }
                public string SecondaryZoneId { get; set; }
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardList ShardList { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardList : TeaModel {
                    [NameInMap("ShardAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardListShardAttribute> ShardAttribute { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardListShardAttribute : TeaModel {
                        [NameInMap("ConnectString")]
                        [Validation(Required=false)]
                        public string ConnectString { get; set; }

                        [NameInMap("MaxConnections")]
                        [Validation(Required=false)]
                        public int? MaxConnections { get; set; }

                        [NameInMap("MaxIOPS")]
                        [Validation(Required=false)]
                        public int? MaxIOPS { get; set; }

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

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("ReadonlyReplicas")]
                        [Validation(Required=false)]
                        public int? ReadonlyReplicas { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }
                public string StorageEngine { get; set; }
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTags Tags { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string VPCCloudInstanceIds { get; set; }
                public string VPCId { get; set; }
                public string VSwitchId { get; set; }
                public string VpcAuthMode { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
