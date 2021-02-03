// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlansResponseBody : TeaModel {
        [NameInMap("RecoveryPlans")]
        [Validation(Required=false)]
        public DescribeGtmRecoveryPlansResponseBodyRecoveryPlans RecoveryPlans { get; set; }
        public class DescribeGtmRecoveryPlansResponseBodyRecoveryPlans : TeaModel {
            [NameInMap("RecoveryPlan")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan> RecoveryPlan { get; set; }
            public class DescribeGtmRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan : TeaModel {
                public string Status { get; set; }
                public long? LastRollbackTimestamp { get; set; }
                public string UpdateTime { get; set; }
                public string Remark { get; set; }
                public string CreateTime { get; set; }
                public long? RecoveryPlanId { get; set; }
                public long? UpdateTimestamp { get; set; }
                public long? LastExecuteTimestamp { get; set; }
                public string LastExecuteTime { get; set; }
                public string LastRollbackTime { get; set; }
                public string Name { get; set; }
                public int? FaultAddrPoolNum { get; set; }
                public long? CreateTimestamp { get; set; }
            }
        };

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

    }

}
