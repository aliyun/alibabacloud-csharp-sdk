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
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("CpuCores")]
                [Validation(Required=false)]
                public int? CpuCores { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DBInstanceCategory")]
                [Validation(Required=false)]
                public string DBInstanceCategory { get; set; }

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

                [NameInMap("EncryptionKey")]
                [Validation(Required=false)]
                public string EncryptionKey { get; set; }

                [NameInMap("EncryptionType")]
                [Validation(Required=false)]
                public string EncryptionType { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("InstanceDeployType")]
                [Validation(Required=false)]
                public string InstanceDeployType { get; set; }

                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("MasterNodeNum")]
                [Validation(Required=false)]
                public int? MasterNodeNum { get; set; }

                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

                [NameInMap("MinorVersion")]
                [Validation(Required=false)]
                public string MinorVersion { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SegNodeNum")]
                [Validation(Required=false)]
                public int? SegNodeNum { get; set; }

                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public int? StorageSize { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("SupportRestore")]
                [Validation(Required=false)]
                public bool? SupportRestore { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

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
