// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsInstInfosResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeRdsInstInfosResponseBodyItems Items { get; set; }
        public class DescribeRdsInstInfosResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeRdsInstInfosResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeRdsInstInfosResponseBodyItemsDBInstance : TeaModel {
                public string DBInstanceDescription { get; set; }
                public string DBInstanceId { get; set; }
                public int? DBInstanceStatus { get; set; }
                public string DBInstanceType { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string InstanceNetworkType { get; set; }
                public DescribeRdsInstInfosResponseBodyItemsDBInstanceReadOnlyDBInstanceId ReadOnlyDBInstanceId { get; set; }
                public class DescribeRdsInstInfosResponseBodyItemsDBInstanceReadOnlyDBInstanceId : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<string> ReadOnlyDBInstanceId { get; set; }

                }
                public string RegionId { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
