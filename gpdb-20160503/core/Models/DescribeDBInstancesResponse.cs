// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancesResponse : TeaModel {
        [NameInMap("TotalRecordCount")]
        [Validation(Required=true)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=true)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public DescribeDBInstancesResponseItems Items { get; set; }
        public class DescribeDBInstancesResponseItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=true)]
            public List<DescribeDBInstancesResponseItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseItemsDBInstance : TeaModel {
                public string EngineVersion { get; set; }
                public string StorageType { get; set; }
                public string ZoneId { get; set; }
                public string DBInstanceStatus { get; set; }
                public string DBInstanceNetType { get; set; }
                public string VSwitchId { get; set; }
                public string CreateTime { get; set; }
                public string LockMode { get; set; }
                public string PayType { get; set; }
                public string InstanceNetworkType { get; set; }
                public string VpcId { get; set; }
                public string DBInstanceId { get; set; }
                public string ConnectionMode { get; set; }
                public string InstanceDeployType { get; set; }
                public string RegionId { get; set; }
                public string LockReason { get; set; }
                public string ExpireTime { get; set; }
                public string DBInstanceDescription { get; set; }
                public string Engine { get; set; }
                public DescribeDBInstancesResponseItemsDBInstanceTags Tags { get; set; }
                public class DescribeDBInstancesResponseItemsDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=true)]
                    public List<DescribeDBInstancesResponseItemsDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstancesResponseItemsDBInstanceTagsTag : TeaModel {
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
