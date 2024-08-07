// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancePlansRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// > You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The time that is used to filter plans. If you specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format, the plans that are created before this time are returned. The time must be in UTC. If you do not specify this parameter, all plans are returned.
        /// </summary>
        [NameInMap("PlanCreateDate")]
        [Validation(Required=false)]
        public string PlanCreateDate { get; set; }

        /// <summary>
        /// The description of the plan.
        /// </summary>
        [NameInMap("PlanDesc")]
        [Validation(Required=false)]
        public string PlanDesc { get; set; }

        /// <summary>
        /// The plan ID.
        /// 
        /// > You can call the [DescribeDBInstancePlans](https://help.aliyun.com/document_detail/449398.html) operation to query the information about plans, including plan IDs.
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

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
        /// The type of the plan. Valid values:
        /// 
        /// *   **PauseResume**: pauses and resumes an instance.
        /// *   **Resize**: scales an instance.
        /// *   **ModifySpec**: changes compute node specifications.
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

    }

}
