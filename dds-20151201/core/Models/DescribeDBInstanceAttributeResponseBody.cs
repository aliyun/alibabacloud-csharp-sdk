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
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("ConfigserverList")]
                [Validation(Required=false)]
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

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("CurrentKernelVersion")]
                [Validation(Required=false)]
                public string CurrentKernelVersion { get; set; }

                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DBInstanceReleaseProtection")]
                [Validation(Required=false)]
                public bool? DBInstanceReleaseProtection { get; set; }

                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("HiddenZoneId")]
                [Validation(Required=false)]
                public string HiddenZoneId { get; set; }

                [NameInMap("KindCode")]
                [Validation(Required=false)]
                public string KindCode { get; set; }

                [NameInMap("LastDowngradeTime")]
                [Validation(Required=false)]
                public string LastDowngradeTime { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                [NameInMap("MaxIOPS")]
                [Validation(Required=false)]
                public int? MaxIOPS { get; set; }

                [NameInMap("MongosList")]
                [Validation(Required=false)]
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

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                [NameInMap("ReadonlyReplicas")]
                [Validation(Required=false)]
                public string ReadonlyReplicas { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReplacateId")]
                [Validation(Required=false)]
                public string ReplacateId { get; set; }

                [NameInMap("ReplicaSetName")]
                [Validation(Required=false)]
                public string ReplicaSetName { get; set; }

                [NameInMap("ReplicaSets")]
                [Validation(Required=false)]
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

                [NameInMap("ReplicationFactor")]
                [Validation(Required=false)]
                public string ReplicationFactor { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                [NameInMap("ShardList")]
                [Validation(Required=false)]
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

                [NameInMap("StorageEngine")]
                [Validation(Required=false)]
                public string StorageEngine { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("VPCCloudInstanceIds")]
                [Validation(Required=false)]
                public string VPCCloudInstanceIds { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcAuthMode")]
                [Validation(Required=false)]
                public string VpcAuthMode { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
