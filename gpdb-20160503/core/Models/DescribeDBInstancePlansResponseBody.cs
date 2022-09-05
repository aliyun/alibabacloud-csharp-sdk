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
            [NameInMap("PlanList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancePlansResponseBodyItemsPlanList> PlanList { get; set; }
            public class DescribeDBInstancePlansResponseBodyItemsPlanList : TeaModel {
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("PlanConfig")]
                [Validation(Required=false)]
                public string PlanConfig { get; set; }

                [NameInMap("PlanDesc")]
                [Validation(Required=false)]
                public string PlanDesc { get; set; }

                [NameInMap("PlanEndDate")]
                [Validation(Required=false)]
                public string PlanEndDate { get; set; }

                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                [NameInMap("PlanName")]
                [Validation(Required=false)]
                public string PlanName { get; set; }

                [NameInMap("PlanScheduleType")]
                [Validation(Required=false)]
                public string PlanScheduleType { get; set; }

                [NameInMap("PlanStartDate")]
                [Validation(Required=false)]
                public string PlanStartDate { get; set; }

                [NameInMap("PlanStatus")]
                [Validation(Required=false)]
                public string PlanStatus { get; set; }

                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

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

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
