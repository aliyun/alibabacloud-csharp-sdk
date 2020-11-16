// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceIPArrayListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public DescribeDBInstanceIPArrayListResponseItems Items { get; set; }
        public class DescribeDBInstanceIPArrayListResponseItems : TeaModel {
            [NameInMap("DBInstanceIPArray")]
            [Validation(Required=true)]
            public List<DescribeDBInstanceIPArrayListResponseItemsDBInstanceIPArray> DBInstanceIPArray { get; set; }
            public class DescribeDBInstanceIPArrayListResponseItemsDBInstanceIPArray : TeaModel {
                public string DBInstanceIPArrayName { get; set; }
                public string DBInstanceIPArrayAttribute { get; set; }
                public string SecurityIPList { get; set; }
            }
        };

    }

}
