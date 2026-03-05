// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstances Instances { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstances : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttribute : TeaModel {
                [NameInMap("ArchitectureType")]
                [Validation(Required=false)]
                public string ArchitectureType { get; set; }

                [NameInMap("AuditLogRetention")]
                [Validation(Required=false)]
                public string AuditLogRetention { get; set; }

                [NameInMap("AutoSecondaryZone")]
                [Validation(Required=false)]
                public bool? AutoSecondaryZone { get; set; }

                [NameInMap("AvailabilityValue")]
                [Validation(Required=false)]
                public string AvailabilityValue { get; set; }

                [NameInMap("BackupLogStartTime")]
                [Validation(Required=false)]
                public string BackupLogStartTime { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CloudType")]
                [Validation(Required=false)]
                public string CloudType { get; set; }

                [NameInMap("ComputingType")]
                [Validation(Required=false)]
                public string ComputingType { get; set; }

                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                [NameInMap("ConnectionDomain")]
                [Validation(Required=false)]
                public string ConnectionDomain { get; set; }

                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("GlobalInstanceId")]
                [Validation(Required=false)]
                public string GlobalInstanceId { get; set; }

                [NameInMap("HasRenewChangeOrder")]
                [Validation(Required=false)]
                public string HasRenewChangeOrder { get; set; }

                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceReleaseProtection")]
                [Validation(Required=false)]
                public bool? InstanceReleaseProtection { get; set; }

                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("IsOrderCompleted")]
                [Validation(Required=false)]
                public bool? IsOrderCompleted { get; set; }

                [NameInMap("IsRds")]
                [Validation(Required=false)]
                public bool? IsRds { get; set; }

                [NameInMap("IsSupportTDE")]
                [Validation(Required=false)]
                public bool? IsSupportTDE { get; set; }

                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("QPS")]
                [Validation(Required=false)]
                public long? QPS { get; set; }

                [NameInMap("ReadOnlyCount")]
                [Validation(Required=false)]
                public int? ReadOnlyCount { get; set; }

                [NameInMap("RealInstanceClass")]
                [Validation(Required=false)]
                public string RealInstanceClass { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReplicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                [NameInMap("ReplicaId")]
                [Validation(Required=false)]
                public string ReplicaId { get; set; }

                [NameInMap("ReplicationMode")]
                [Validation(Required=false)]
                public string ReplicationMode { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                [NameInMap("ShardCount")]
                [Validation(Required=false)]
                public int? ShardCount { get; set; }

                [NameInMap("SlaveReadOnlyCount")]
                [Validation(Required=false)]
                public long? SlaveReadOnlyCount { get; set; }

                [NameInMap("SlaveReplicaCount")]
                [Validation(Required=false)]
                public int? SlaveReplicaCount { get; set; }

                [NameInMap("Storage")]
                [Validation(Required=false)]
                public string Storage { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTags Tags { get; set; }
                public class DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTagsTag> Tag { get; set; }
                    public class DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcAuthMode")]
                [Validation(Required=false)]
                public string VpcAuthMode { get; set; }

                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA40C261-EB72-4EDA-AC57-958722162595</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
