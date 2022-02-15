// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceOnECSAttributeResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceOnECSAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceOnECSAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceOnECSAttributeResponseBodyItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstanceOnECSAttributeResponseBodyItemsDBInstanceAttribute : TeaModel {
                public string ConnectionMode { get; set; }
                public string ConnectionString { get; set; }
                public int? CpuCores { get; set; }
                public string CreationTime { get; set; }
                public string DBInstanceCategory { get; set; }
                public string DBInstanceClass { get; set; }
                public string DBInstanceDescription { get; set; }
                public string DBInstanceId { get; set; }
                public string DBInstanceStatus { get; set; }
                public string EncryptionKey { get; set; }
                public string EncryptionType { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string ExpireTime { get; set; }
                public string InstanceDeployType { get; set; }
                public string InstanceNetworkType { get; set; }
                public string LockMode { get; set; }
                public int? MasterNodeNum { get; set; }
                public int? MemorySize { get; set; }
                public string MinorVersion { get; set; }
                public string PayType { get; set; }
                public string Port { get; set; }
                public string RegionId { get; set; }
                public int? SegNodeNum { get; set; }
                public int? StorageSize { get; set; }
                public string StorageType { get; set; }
                public bool? SupportRestore { get; set; }
                public DescribeDBInstanceOnECSAttributeResponseBodyItemsDBInstanceAttributeTags Tags { get; set; }
                public class DescribeDBInstanceOnECSAttributeResponseBodyItemsDBInstanceAttributeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceOnECSAttributeResponseBodyItemsDBInstanceAttributeTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceOnECSAttributeResponseBodyItemsDBInstanceAttributeTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
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
