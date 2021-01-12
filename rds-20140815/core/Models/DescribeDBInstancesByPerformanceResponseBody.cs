// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesByPerformanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesByPerformanceResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesByPerformanceResponseBodyItems : TeaModel {
            [NameInMap("DBInstancePerformance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesByPerformanceResponseBodyItemsDBInstancePerformance> DBInstancePerformance { get; set; }
            public class DescribeDBInstancesByPerformanceResponseBodyItemsDBInstancePerformance : TeaModel {
                public string CPUUsage { get; set; }
                public string IOPSUsage { get; set; }
                public string DiskUsage { get; set; }
                public string SessionUsage { get; set; }
                public string DBInstanceId { get; set; }
                public string DBInstanceDescription { get; set; }
            }
        };

    }

}
