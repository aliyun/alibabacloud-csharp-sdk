// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class DescribeRecoveryPlansResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RecoveryPlans")]
        [Validation(Required=false)]
        public DescribeRecoveryPlansResponseBodyRecoveryPlans RecoveryPlans { get; set; }
        public class DescribeRecoveryPlansResponseBodyRecoveryPlans : TeaModel {
            [NameInMap("recoveryPlan")]
            [Validation(Required=false)]
            public List<DescribeRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan> RecoveryPlan { get; set; }
            public class DescribeRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan : TeaModel {
                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RecoveryPlanId")]
                [Validation(Required=false)]
                public string RecoveryPlanId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
