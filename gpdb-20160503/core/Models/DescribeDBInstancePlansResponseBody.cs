// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancePlansResponseBody : TeaModel {
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancePlansResponseBodyItems Items { get; set; }
        public class DescribeDBInstancePlansResponseBodyItems : TeaModel {
            [NameInMap("Plan")]
            [Validation(Required=false)]
            public List<DescribeDBInstancePlansResponseBodyItemsPlan> Plan { get; set; }
            public class DescribeDBInstancePlansResponseBodyItemsPlan : TeaModel {
                public string DBInstanceId { get; set; }
                public string PlanConfig { get; set; }
                public string PlanDesc { get; set; }
                public string PlanEndTime { get; set; }
                public string PlanId { get; set; }
                public string PlanName { get; set; }
                public string PlanStartTime { get; set; }
                public string PlanType { get; set; }
                public string PlanscheduleType { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
