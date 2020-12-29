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
        public List<DescribeGtmRecoveryPlansResponseBodyRecoveryPlans> RecoveryPlans { get; set; }
        public class DescribeGtmRecoveryPlansResponseBodyRecoveryPlans : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("LastRollbackTimestamp")]
            [Validation(Required=false)]
            public long? LastRollbackTimestamp { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("RecoveryPlanId")]
            [Validation(Required=false)]
            public long? RecoveryPlanId { get; set; }

            [NameInMap("UpdateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

            [NameInMap("LastExecuteTimestamp")]
            [Validation(Required=false)]
            public long? LastExecuteTimestamp { get; set; }

            [NameInMap("LastExecuteTime")]
            [Validation(Required=false)]
            public string LastExecuteTime { get; set; }

            [NameInMap("LastRollbackTime")]
            [Validation(Required=false)]
            public string LastRollbackTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("FaultAddrPoolNum")]
            [Validation(Required=false)]
            public int? FaultAddrPoolNum { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

        }

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
