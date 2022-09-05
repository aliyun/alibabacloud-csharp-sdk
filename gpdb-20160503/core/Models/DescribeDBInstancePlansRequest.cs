// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancePlansRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PlanCreateDate")]
        [Validation(Required=false)]
        public string PlanCreateDate { get; set; }

        [NameInMap("PlanDesc")]
        [Validation(Required=false)]
        public string PlanDesc { get; set; }

        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        [NameInMap("PlanScheduleType")]
        [Validation(Required=false)]
        public string PlanScheduleType { get; set; }

        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

    }

}
