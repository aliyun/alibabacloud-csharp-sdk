// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancePlansResponseBody : TeaModel {
        /// <summary>
        /// The error message.
        /// 
        /// This parameter is returned only if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The queried plans.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancePlansResponseBodyItems Items { get; set; }
        public class DescribeDBInstancePlansResponseBodyItems : TeaModel {
            [NameInMap("PlanList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancePlansResponseBodyItemsPlanList> PlanList { get; set; }
            public class DescribeDBInstancePlansResponseBodyItemsPlanList : TeaModel {
                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The execution information of the plan.
                /// </summary>
                [NameInMap("PlanConfig")]
                [Validation(Required=false)]
                public string PlanConfig { get; set; }

                /// <summary>
                /// The description of the plan.
                /// </summary>
                [NameInMap("PlanDesc")]
                [Validation(Required=false)]
                public string PlanDesc { get; set; }

                /// <summary>
                /// The end time of the plan. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// 
                /// > 
                /// 
                /// *   This parameter is returned only for the plans that are periodically executed.
                /// 
                /// *   If you did not specify the end time when you created the plan, this parameter is not returned.
                /// </summary>
                [NameInMap("PlanEndDate")]
                [Validation(Required=false)]
                public string PlanEndDate { get; set; }

                /// <summary>
                /// The plan ID.
                /// </summary>
                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                /// <summary>
                /// The name of the plan.
                /// </summary>
                [NameInMap("PlanName")]
                [Validation(Required=false)]
                public string PlanName { get; set; }

                /// <summary>
                /// The execution mode of the plan. Valid values:
                /// 
                /// *   **Postpone**: The plan is executed later.
                /// *   **Regular**: The plan is executed periodically.
                /// </summary>
                [NameInMap("PlanScheduleType")]
                [Validation(Required=false)]
                public string PlanScheduleType { get; set; }

                /// <summary>
                /// The start time of the plan. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// 
                /// > 
                /// 
                /// *   This parameter is returned only for the plans that are periodically executed.
                /// 
                /// *   If you did not specify the start time when you created the plan, the current time is returned.
                /// </summary>
                [NameInMap("PlanStartDate")]
                [Validation(Required=false)]
                public string PlanStartDate { get; set; }

                /// <summary>
                /// The status of the plan. Valid values:
                /// 
                /// *   **active**
                /// *   **cancel**
                /// *   **deleted**
                /// *   **finished**
                /// </summary>
                [NameInMap("PlanStatus")]
                [Validation(Required=false)]
                public string PlanStatus { get; set; }

                /// <summary>
                /// The type of the plan. Valid values:
                /// 
                /// *   **PauseResume**: pauses and resumes an instance.
                /// *   **Resize**: scales an instance.
                /// </summary>
                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// 
        /// If the request was successful, **success** is returned. If the request failed, this parameter is not returned.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
