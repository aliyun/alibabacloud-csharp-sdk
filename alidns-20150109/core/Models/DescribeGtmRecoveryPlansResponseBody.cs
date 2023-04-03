// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlansResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The details about the queried disaster recovery plans.
        /// </summary>
        [NameInMap("RecoveryPlans")]
        [Validation(Required=false)]
        public DescribeGtmRecoveryPlansResponseBodyRecoveryPlans RecoveryPlans { get; set; }
        public class DescribeGtmRecoveryPlansResponseBodyRecoveryPlans : TeaModel {
            [NameInMap("RecoveryPlan")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan> RecoveryPlan { get; set; }
            public class DescribeGtmRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan : TeaModel {
                /// <summary>
                /// The time when the disaster recovery plan was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The UNIX timestamp that indicates when the disaster recovery plan was created.
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The number of faulty address pools.
                /// </summary>
                [NameInMap("FaultAddrPoolNum")]
                [Validation(Required=false)]
                public int? FaultAddrPoolNum { get; set; }

                /// <summary>
                /// The last time when the disaster recovery plan was executed.
                /// </summary>
                [NameInMap("LastExecuteTime")]
                [Validation(Required=false)]
                public string LastExecuteTime { get; set; }

                /// <summary>
                /// The UNIX timestamp that indicates the last time when the disaster recovery plan was executed.
                /// </summary>
                [NameInMap("LastExecuteTimestamp")]
                [Validation(Required=false)]
                public long? LastExecuteTimestamp { get; set; }

                /// <summary>
                /// The last time when the disaster recovery plan was rolled back.
                /// </summary>
                [NameInMap("LastRollbackTime")]
                [Validation(Required=false)]
                public string LastRollbackTime { get; set; }

                /// <summary>
                /// The UNIX timestamp that indicates the last time when the disaster recovery plan was rolled back.
                /// </summary>
                [NameInMap("LastRollbackTimestamp")]
                [Validation(Required=false)]
                public long? LastRollbackTimestamp { get; set; }

                /// <summary>
                /// The name of the disaster recovery plan.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the disaster recovery plan.
                /// </summary>
                [NameInMap("RecoveryPlanId")]
                [Validation(Required=false)]
                public long? RecoveryPlanId { get; set; }

                /// <summary>
                /// The remarks about the disaster recovery plan.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The status of the disaster recovery plan. Valid values:
                /// 
                /// *   **UNEXECUTED**: The plan is not executed.
                /// *   **EXECUTED**: The plan is executed.
                /// *   **ROLLED_BACK**: The plan is rolled back.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The last time when the disaster recovery plan was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The UNIX timestamp that indicates the last time when the disaster recovery plan was updated.
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
