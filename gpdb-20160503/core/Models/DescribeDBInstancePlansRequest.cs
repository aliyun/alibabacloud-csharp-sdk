// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancePlansRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  You can call the [DescribeDBInstances](~~86911~~) operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including instance IDs.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The time used to filter plans. If you specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format, the plans created before this time are returned. The time must be in UTC. If you do not specify this parameter, all plans are returned.
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
        /// The ID of the plan.
        /// 
        /// >  You can call the [DescribeDBInstancePlans](~~449398~~) operation to query the details of plans, including plan IDs.
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
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

    }

}
