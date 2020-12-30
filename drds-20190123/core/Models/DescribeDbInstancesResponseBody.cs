// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDbInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDbInstancesResponseBodyItems Items { get; set; }
        public class DescribeDbInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDbInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDbInstancesResponseBodyItemsDBInstance : TeaModel {
                [NameInMap("ReadOnlyDBInstanceId")]
                [Validation(Required=false)]
                public List<string> ReadOnlyDBInstanceId { get; set; }

            }
        };

    }

}
