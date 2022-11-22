// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesByPerformanceResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesByPerformanceResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesByPerformanceResponseBodyItems : TeaModel {
            [NameInMap("DBInstancePerformance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesByPerformanceResponseBodyItemsDBInstancePerformance> DBInstancePerformance { get; set; }
            public class DescribeDBInstancesByPerformanceResponseBodyItemsDBInstancePerformance : TeaModel {
                [NameInMap("CPUUsage")]
                [Validation(Required=false)]
                public string CPUUsage { get; set; }

                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DiskUsage")]
                [Validation(Required=false)]
                public string DiskUsage { get; set; }

                [NameInMap("IOPSUsage")]
                [Validation(Required=false)]
                public string IOPSUsage { get; set; }

                [NameInMap("SessionUsage")]
                [Validation(Required=false)]
                public string SessionUsage { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
