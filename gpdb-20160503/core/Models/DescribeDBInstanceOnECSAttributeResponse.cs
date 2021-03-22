// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceOnECSAttributeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public DescribeDBInstanceOnECSAttributeResponseItems Items { get; set; }
        public class DescribeDBInstanceOnECSAttributeResponseItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=true)]
            public List<DescribeDBInstanceOnECSAttributeResponseItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstanceOnECSAttributeResponseItemsDBInstanceAttribute : TeaModel {
                public int? MasterNodeNum { get; set; }
                public int? SegNodeNum { get; set; }
                public string Port { get; set; }
                public string EncryptionKey { get; set; }
                public string InstanceNetworkType { get; set; }
                public string DBInstanceId { get; set; }
                public string Engine { get; set; }
                public string DBInstanceDescription { get; set; }
                public int? MemorySize { get; set; }
                public string EncryptionType { get; set; }
                public string EngineVersion { get; set; }
                public string StorageType { get; set; }
                public string ZoneId { get; set; }
                public string DBInstanceStatus { get; set; }
                public string DBInstanceClass { get; set; }
                public string VSwitchId { get; set; }
                public int? StorageSize { get; set; }
                public string LockMode { get; set; }
                public string PayType { get; set; }
                public string VpcId { get; set; }
                public int? CpuCores { get; set; }
                public string ConnectionMode { get; set; }
                public string InstanceDeployType { get; set; }
                public string CreationTime { get; set; }
                public string RegionId { get; set; }
                public string ExpireTime { get; set; }
                public string ConnectionString { get; set; }
                public DescribeDBInstanceOnECSAttributeResponseItemsDBInstanceAttributeTags Tags { get; set; }
                public class DescribeDBInstanceOnECSAttributeResponseItemsDBInstanceAttributeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=true)]
                    public List<DescribeDBInstanceOnECSAttributeResponseItemsDBInstanceAttributeTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceOnECSAttributeResponseItemsDBInstanceAttributeTagsTag : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=true)]
                        public string Value { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=true)]
                        public string Key { get; set; }

                    }

                }
            }
        };

    }

}
