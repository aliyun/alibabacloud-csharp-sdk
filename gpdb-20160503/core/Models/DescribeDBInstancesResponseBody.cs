// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
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
        public DescribeDBInstancesResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseBodyItemsDBInstance : TeaModel {
                public string VpcId { get; set; }
                public string ExpireTime { get; set; }
                public string DBInstanceNetType { get; set; }
                public string InstanceDeployType { get; set; }
                public string StorageType { get; set; }
                public string CreateTime { get; set; }
                public string PayType { get; set; }
                public DescribeDBInstancesResponseBodyItemsDBInstanceTags Tags { get; set; }
                public class DescribeDBInstancesResponseBodyItemsDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyItemsDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstancesResponseBodyItemsDBInstanceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string LockReason { get; set; }
                public string DBInstanceStatus { get; set; }
                public string ConnectionMode { get; set; }
                public string LockMode { get; set; }
                public string EngineVersion { get; set; }
                public string RegionId { get; set; }
                public string VSwitchId { get; set; }
                public string InstanceNetworkType { get; set; }
                public string ZoneId { get; set; }
                public string DBInstanceId { get; set; }
                public string Engine { get; set; }
                public string DBInstanceDescription { get; set; }
                public string SegNodeNum { get; set; }
                public string StorageSize { get; set; }
                public int? MasterNodeNum { get; set; }
                public string DBInstanceCategory { get; set; }
            }
        };

    }

}
