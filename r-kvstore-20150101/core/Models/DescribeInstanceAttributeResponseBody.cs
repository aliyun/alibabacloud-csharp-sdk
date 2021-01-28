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
                public string VpcId { get; set; }
                public string PrivateIp { get; set; }
                public long? Capacity { get; set; }
                public string CreateTime { get; set; }
                public string ConnectionDomain { get; set; }
                public bool? IsRds { get; set; }
                public string ChargeType { get; set; }
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
                public string VpcAuthMode { get; set; }
                public string ArchitectureType { get; set; }
                public string NetworkType { get; set; }
                public string AvailabilityValue { get; set; }
                public long? Port { get; set; }
                public string Config { get; set; }
                public string EngineVersion { get; set; }
                public string PackageType { get; set; }
                public string VpcCloudInstanceId { get; set; }
                public long? Bandwidth { get; set; }
                public string InstanceName { get; set; }
                public string SecurityIPList { get; set; }
                public int? ShardCount { get; set; }
                public string GlobalInstanceId { get; set; }
                public long? QPS { get; set; }
                public string AuditLogRetention { get; set; }
                public string MaintainStartTime { get; set; }
                public string InstanceClass { get; set; }
                public string MaintainEndTime { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public string HasRenewChangeOrder { get; set; }
                public bool? InstanceReleaseProtection { get; set; }
                public string ReplicationMode { get; set; }
                public string RegionId { get; set; }
                public string EndTime { get; set; }
                public string VSwitchId { get; set; }
                public string ReplicaId { get; set; }
                public string NodeType { get; set; }
                public long? Connections { get; set; }
                public string ResourceGroupId { get; set; }
                public string ZoneId { get; set; }
                public string InstanceStatus { get; set; }
                public string Engine { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
