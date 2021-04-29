// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesByExpireTimeResponseBody : TeaModel {
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
        public DescribeDBInstancesByExpireTimeResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesByExpireTimeResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceExpireTime")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesByExpireTimeResponseBodyItemsDBInstanceExpireTime> DBInstanceExpireTime { get; set; }
            public class DescribeDBInstancesByExpireTimeResponseBodyItemsDBInstanceExpireTime : TeaModel {
                public string ExpireTime { get; set; }
                public string PayType { get; set; }
                public string DBInstanceId { get; set; }
                public string DBInstanceStatus { get; set; }
                public string DBInstanceDescription { get; set; }
                public string LockMode { get; set; }
            }
        };

    }

}
