// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceIPArrayListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceIPArrayListResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceIPArrayListResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceIPArray")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray> DBInstanceIPArray { get; set; }
            public class DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray : TeaModel {
                public string DBInstanceIPArrayName { get; set; }
                public string SecurityIPType { get; set; }
                public string SecurityIPList { get; set; }
                public string DBInstanceIPArrayAttribute { get; set; }
            }
        };

    }

}
